(function ($) {

    // default options
    var defaultSettings = {
        // desktop view settings
        logo_show                      : true,      // Options (true) or (false). This option is used to show or hide the logo.
        logo_align                     : 'left',    // Options (left) or (right). This option is used to align the logo left or right side of the screen.
        search_bar_show                : true,      // Options (true) or (false). This option is used to show or hide the search bar.
        search_bar_align               : 'right',   // Options (right) or (left). This option is used to align the search bar left or right side of the screen.
        icons_show                     : true,      // Options (true) or (false). This option is used to show or hide the menu items icons.
        social_icons_show              : true,      // Options (true) or (false). This option is used to show or hide the social icons.
        social_icons_align             : 'right',   // Options (right) or (left). This option is used to align the social icons left or right side of the screen.
        element_effects                : 'fade',    // Options (fade), (sweep-to-right), (sweep-to-left), (sweep-to-top), (sweep-to-bottom), (bounce-to-right), (bounce-to-left), (bounce-to-top), (bounce-to-bottom), (radial-out), (rectangle-out), (shutter-out-horizontal), (shutter-out-vertical), (underline-from-left), (underline-from-center), (underline-from-right), (overline-from-left), (overline-from-center) or (overline-from-right). This option is used to change the menu items hover effects.
        top_bar_show                   : true,      // Options (true) or (false). This option is used to show or hide the menu top bar.
        separator_show                 : true,      // Options (true) or (false). This option is used to show or hide the vertical line between menu items.
        // drop down settings
        drop_down_trigger_in           : 'hover',   // Options (click) or (hover). This option is used to show the drop down on mouse click or mouse hover.
        drop_down_trigger_out          : 'hover',   // Options (click) or (hover). This option is used to hide the drop down on mouse click or mouse hover.
        //drop_down_effect               : 'fade',    // Options (fade), (sweep-to-right), (sweep-to-left), (sweep-to-top), (sweep-to-bottom) or (scale). This option is used to change the drop down animation.
        drop_down_effect_speed         : 500,       // This option is used to change the drop down animation speed. Speed set in integer value
        drop_down_delay_in             : 100,       // This option is used to change the drop down showing delay. Speed set in integer value.
        drop_down_delay_out            : 100,       // This option is used to change the drop down hiding delay. Speed set in integer value.
        drop_down_indicator_icon       : 'fa-chevron-circle-right',    // This option is used to change the drop down indicator font-awesome icon. source: https://fortawesome.github.io/Font-Awesome/examples/.
        drop_down_overflow_hide        : false,     // Options (true) or (false). This option is used to hide the long drop downs. Note: this option works on large or medium side drop downs.
        outside_click_hide_drop_down   : true,      // Options (true) or  (false). This option is used to hide the showing drop downs when user click out side the menu.
        // sidebar settings
        sidebar_show                   : true,      // Options (true) or (false). This option is used to show or hide the side bar.
        sidebar_trigger                : 'click',   // Options (click) or (hover). This option is used to show the side bar on mouse click or mouse hover.
        outside_click_hide_sidebar     : true,      // Options (true) or (false). This option is used to hide the showing sidebar when user click outside the menu.
        // sticky header
        sticky_header_menu             : false,     // Options (true) or (false). This option is used to make the menu sticky top of the screen on desktop view.
        sticky_header_height           : 100,       // This option is used to change the sticky menu height top of the screen. It means when menu reach this height while scroll top to bottom.
        // mobile view settings
        logo_show_mobile               : true,      // Options (true) or (false) This options used to show or hide the logo on mobile view.
        search_bar_show_mobile         : true,      // Options (true) or (false) This option is used to show or hide the search bar on mobile view.
        icons_show_mobile              : true,      // Options (true) or (false) This option is used to show or hide the menu items icons on mobile view.
        social_icons_show_mobile       : true,      // Options (true) or (false) This option is used to show or hide the social icons on mobile view.
        top_bar_show_mobile            : false,     // Options (true) or (false) This option is used to show or hide the top bar on mobile view.
        sidebar_show_mobile            : true,      // Options (true) or (false) This option is used to show or hide the sidebar on mobile view.
        collapse_sub_menu_show         : false,     // Options (true) or (false) This option is used to show or hide the menu on mobile view.
        sticky_header_menu_mobile      : false,     // Options (true) or (false). This option is used to make the menu sticky top of the screen on mobile view.
        drop_down_indicator_icon_mobile: 'fa-chevron-circle-down' // This option is used to change the drop down indicator font-awesome icon on mobile view. source: https://fortawesome.github.io/Font-Awesome/examples/.
    };

    // development
    $.fn.flatMenu = function (settings) {
        settings = $.extend({}, defaultSettings, settings || {});
        return this.each(function () {

            // variables
            var $this = $(this),
                $logo_hide_class = 'links-border-radius',
                $search_bar_hide_desktop = 'search-bar-hide',
                $search_bar_hide_mobile = 'search-bar-hide-mobile',
                $icons_hide_desktop = 'icons-hide',
                $icons_hide_mobile = 'icons-hide-mobile',
                $logo_align_class = 'logo-align-right',
                $search_align_class = 'search_align_left',
                $social_icons_hide_class = 'social_icons_hide',
                $social_icons_align_class = 'social_icons_align_left',
                $top_bar_radius_class = 'top-bar-show-radius',
                $top_bar_show_class = 'top-bar-show',
                $separator_hide_class = 'separator_hide',
                $drop_down_indicator = $this.find('.drop-down .drop-down'),
                $trigger = $this.find('.drop-down'),
                $drop_down = '>.drop-down',
                $active_class = 'active',
                $active_drop_down_class = 'activeDropDown',
                $li_active_class = $this.find('section.nav-header > ul.nav-links > li'),
                $profile = $this.find('.nav-sidebar-profile'),
                $profile_sidebar = $this.find('.nav-sidebar'),
                $spinner_icon = 'ajax_icon_spinner',
                $mobile_trigger_button = $this.find('#mobiletrigger'), //$this.find('.mobile-trigger'),
                $collapse_class = 'collapse-show',
                $sticky_header_desktop_class = 'nav-sticky-header-desktop',
                $overflow_hide_class = 'overflow-drop-down',
                $object,
                Canvas;

            // functions
            Canvas = (function () {

                // constructor
                function Canvas(name) {
                    this.name = name;
                }

                // drop down overflow hide
                Canvas.prototype.drop_down_overflow = function () {
                    // check if the drop down overflow hide option is true
                    if (settings.drop_down_overflow_hide === true) {
                        // add over flow hide class
                        $this.addClass($overflow_hide_class);
                    }
                };

                // sticky header function
                Canvas.prototype.sticky_header_function = function () {
                    // variable
                    var expand = true;
                    // windows scroll function
                    $(window).on('scroll', function () {
                        // check window height top fo the screen
                        if ($(window).scrollTop() > settings.sticky_header_height) {
                            // check if the expand variable is true
                            if (expand === true) {
                                // hide the menu using animation
                                $this.stop(true, true).fadeOut(400, function () {
                                    // add sticky header class on desktop view
                                    $this.addClass($sticky_header_desktop_class);
                                    // show the menu using animation
                                    $(this).stop(true, true).fadeIn(400);
                                });
                                // make expand variable false
                                expand = false;
                            }
                        } else {
                            // check if the expand variable is false
                            if (expand === false) {
                                // hide the menu using animation
                                $this.stop(true, true).fadeOut(400, function () {
                                    // add sticky header class on desktop view
                                    $this.removeClass($sticky_header_desktop_class);
                                    // show the menu using animation
                                    $(this).stop(true, true).fadeIn(400);
                                });
                                // make expand variable true
                                expand = true;
                            }

                        }
                    });
                };

                // sticky header
                Canvas.prototype.sticky_header = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // check if the sticky header menu option is true
                        if (settings.sticky_header_menu === true) {
                            // call sticky header function
                            this.sticky_header_function();
                        }

                    } else {
                        // check if the mobile view
                        // check if the sticky header mobile option is true
                        if (settings.sticky_header_menu_mobile === true) {
                            // call sticky header function
                            this.sticky_header_function();
                        }
                    }
                };

                // mobile trigger function
                Canvas.prototype.mobile_trigger = function () {

                    // add the click trigger on mobile button
                    $mobile_trigger_button.off('click').on('click', function () {
                        // show the hidden collapse menu
                        $this.toggleClass($collapse_class);
                    });

                    // check if the collapse sub menu show option is true
                    if (settings.collapse_sub_menu_show === true) {
                        // show the collapse sub menu
                        $this.addClass($collapse_class);
                    } else {
                        // remove the collapse class
                        $this.removeClass($collapse_class);
                    }

                };

                // form message send using ajax
                Canvas.prototype.ajax_form = function () {
                    // Get the form.
                    var form = $('#nav-ajax-contact');
                    // Get the messages div.
                    var formMessages = $('#form-messages');
                    // Set up an event listener for the contact form.
                    $(form).submit(function (event) {
                        // show the spinner icon
                        $this.addClass($spinner_icon);
                        // Stop the browser from submitting the form.
                        event.preventDefault();
                        // Serialize the form data.
                        var formData = $(form).serialize();
                        // Submit the form using AJAX.
                        $.ajax({
                                type: 'POST',
                                url : $(form).attr('action'),
                                data: formData
                            })
                            .done(function (response) {
                                // Make sure that the formMessages div has the 'success' class.
                                $(formMessages).removeClass('error');
                                $(formMessages).addClass('success');
                                // hide the message after some time
                                setTimeout(function () {
                                    $(formMessages).removeClass('error');
                                    $(formMessages).removeClass('success');
                                    // remove spinner icon
                                    $this.removeClass($spinner_icon);
                                }, 5000);
                                // Set the message text.
                                $(formMessages).text(response);
                                // Clear the form.
                                $('#form-subject').val('');
                                $('#form-email').val('');
                                $('#form-message').val('');
                            })
                            .fail(function (data) {
                                // Make sure that the formMessages div has the 'error' class.
                                $(formMessages).removeClass('success');
                                $(formMessages).addClass('error');
                                // hide the message after some time
                                setTimeout(function () {
                                    $(formMessages).removeClass('error');
                                    $(formMessages).removeClass('success');
                                    // remove spinner icon
                                    $this.removeClass($spinner_icon);
                                }, 5000);
                                // Set the message text.
                                if (data.responseText !== '') {
                                    $(formMessages).text(data.responseText);
                                } else {
                                    $(formMessages).text('Error');
                                }
                            });
                    });
                };

                // sidebar show or hide function
                Canvas.prototype.sidebar_Show = function (desktop) {

                    // close button for hide the
                    $profile.find('.fa-times').off('click').on('click', function () {
                        // hide
                        $profile.fadeOut(settings.drop_down_effect_speed);
                    });

                    // check if the desktop view
                    if (desktop === true) {

                        // check if the sidebar show option is false
                        if (settings.sidebar_show === false) {
                            // hide the profile button
                            $profile_sidebar.hide(0);
                        }

                        // check if the sidebar trigger is click
                        if (settings.sidebar_trigger === 'click') {
                            // show the profile sidebar
                            $profile_sidebar.on('click', function (event) {
                                event.preventDefault();
                                event.stopPropagation();
                                event.stopImmediatePropagation();
                                // show
                                $profile.stop(true, true).delay(settings.drop_down_delay_in).fadeIn(settings.drop_down_effect_speed);
                            });
                        }

                        // check if the sidebar trigger is hover
                        if (settings.sidebar_trigger === 'hover') {
                            // show the profile sidebar on mouse hover
                            $profile_sidebar.on('mouseenter', function () {
                                // show
                                $profile.stop(true, true).delay(settings.drop_down_delay_in).fadeIn(settings.drop_down_effect_speed);
                            });
                        }
                    } else {
                        // check if the mobile view
                        // check if the sidebar show mobile option is false
                        if (settings.sidebar_show_mobile === false) {
                            // hide the profile button on mobile view
                            $profile_sidebar.hide(0);
                        }

                        // show the profile sidebar
                        $profile_sidebar.on('click', function (event) {
                            event.preventDefault();
                            event.stopPropagation();
                            event.stopImmediatePropagation();
                            // show
                            $profile.stop(true, true).fadeIn(settings.drop_down_effect_speed);
                            // hide the others drop downs
                            $trigger.removeClass($active_class);
                        });
                    }
                };

                // hide the drop down when click outside the menu
                Canvas.prototype.outside_click_close = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {

                        // check if the outside click hide the drop down option is true
                        if (settings.outside_click_hide_drop_down === true) {
                            // add the mouse up function on window
                            $(window).on('mouseup', function (event) {
                                // check if the mouse not on menu
                                if (!$this.is(event.target) && $this.has(event.target).length === 0) {
                                    // remove active class from drop down
                                    $trigger.removeClass($active_class);
                                    // remove active class from li elements
                                    $li_active_class.removeClass($active_drop_down_class);
                                }
                            });
                        }

                        // check if the outside click hide sidebar option is true
                        if (settings.outside_click_hide_sidebar === true) {
                            // add the mouse up function on window
                            $(window).on('mouseup', function (event) {
                                // check if the mouse not on menu
                                if (!$this.is(event.target) && $this.has(event.target).length === 0) {
                                    // hide the profile
                                    $profile.fadeOut(settings.drop_down_effect_speed);
                                }
                            });
                        }
                    }
                };

                // drop down trigger click mobile
                Canvas.prototype.drop_down_trigger_mobile = function (mobile) {
                    // check if the mobile view
                    if (mobile === false) {
                        // add the click trigger on a tag
                        $trigger.prev('a').on({
                            // click function
                            click: function (event, check) {
                                //event.preventDefault();
                                event.stopPropagation();
                                event.stopImmediatePropagation();
                                // drop down
                                check = $(this).next($trigger);
                                // check if the drop down is hidden
                                if (check.css('display') === 'none') {
                                    // add class active or show the drop down
                                    check.addClass($active_class);
                                    // remove class active for others drop downs
                                    check.parents('li').siblings('li').find($trigger).removeClass($active_class);
                                } else {
                                    // remove class active
                                    check.removeClass($active_class);
                                    check.parent('li').find($trigger).removeClass($active_class);
                                }
                                // turn on off the event.preventDefault() event on mobile mode
                                var $nav_width = $this.innerWidth(),    // get the container width
                                    $test = Math.round($nav_width / 1.4), // half the container width
                                    $page_x = event.pageX;              // get the mouse pageX position
                                // on off the event
                                if ($page_x > $test) {
                                    event.preventDefault();
                                }

                            }
                        });
                    }
                };

                // drop down trigger click
                Canvas.prototype.drop_down_trigger_click = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // check if the drop down trigger option is click
                        if (settings.drop_down_trigger_in === 'click') {
                            // add the click trigger on a tag
                            $trigger.prev('a').on({
                                // click function
                                click: function (event, check) {
                                    event.preventDefault();
                                    event.stopPropagation();
                                    event.stopImmediatePropagation();

                                    // set the drop down indicator according to mouse position
                                    var position = event.pageX - 38;
                                    $this.find('.ul_indicator').css('left', '' + position + 'px');

                                    // drop down
                                    check = $(this).next($trigger);
                                    // check if the drop down is hidden
                                    if (check.css('visibility') === 'hidden') {
                                        // add class active or show the drop down
                                        check.stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                            $(this).addClass($active_class);
                                        });
                                        // remove class active for others drop downs
                                        check.parents('li').siblings('li').find($trigger).removeClass($active_class);
                                        // add active class on li
                                        check.parent('li').stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                            $(this).addClass($active_drop_down_class);
                                        });
                                        // remove class active on others li
                                        check.parents('li').siblings('li').removeClass($active_drop_down_class);
                                    }
                                }
                            });
                        }

                        // check if the drop down trigger option is click
                        if (settings.drop_down_trigger_out === 'click') {
                            // add the click trigger on a tag
                            $trigger.prev('a').on({
                                // click function
                                mousedown: function (event, check) {
                                    event.preventDefault();
                                    event.stopPropagation();
                                    event.stopImmediatePropagation();
                                    // drop down
                                    check = $(this).next($trigger);
                                    // check if the drop down is hidden
                                    if (check.css('visibility') === 'visible') {
                                        // remove class active
                                        check.stop(true, true).delay(settings.drop_down_delay_out).queue(function () {
                                            $(this).removeClass($active_class);
                                        });
                                        check.parent('li').find($trigger).stop(true, true).delay(settings.drop_down_delay_out).queue(function () {
                                            $(this).removeClass($active_class);
                                        });
                                        // remove active class on li
                                        check.parent('li').stop(true, true).delay(settings.drop_down_delay_out).queue(function () {
                                            $(this).removeClass($active_drop_down_class);
                                        });
                                    }
                                }
                            });
                        }
                    }
                };

                // drop down trigger hover
                Canvas.prototype.drop_down_trigger_hover = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // check if the drop down trigger option is hover on desktop view
                        if (settings.drop_down_trigger_in === 'hover') {
                            // li elements add hover function
                            $trigger.parent('li').on({
                                // mouseenter function
                                mouseenter: function (event) {

                                    // set the drop down indicator according to mouse position
                                    var position = event.pageX - 38;
                                    $this.find('.ul_indicator').css('left', '' + position + 'px');

                                    // add class active
                                    $(this).find($drop_down).stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                        $(this).addClass($active_class);
                                    });
                                    // add active class on li
                                    $(this).stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                        $(this).addClass($active_drop_down_class);
                                    });

                                    // hide other drop downs
                                    $(this).siblings('li').find($trigger).stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                        $(this).removeClass($active_class);
                                    });

                                    // hide other drop down indicator
                                    $(this).siblings('li').stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                        $(this).removeClass($active_drop_down_class);
                                    });

                                    //Agregado para que muestre abierta la primera opcion de Menu
                                    //var lObj = $(this).find($drop_down);
                                    //if (lObj.length > 0) {
                                    //    if ((lObj[0].parentNode != undefined) && (lObj[0].parentNode != null)) {
                                    //        if (lObj[0].parentNode.id == "quasarMenu") {
                                    //            $("#RecientesyFav").find($drop_down).stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                    //                $(this).addClass($active_class);
                                    //            });
                                    //            // add active class on li
                                    //            $("#RecientesyFav").stop(true, true).delay(settings.drop_down_delay_in).queue(function () {
                                    //                $(this).addClass($active_drop_down_class);
                                    //            });
                                    //        }
                                    //    }
                                    //}
                                    //fin agregado

                                }
                            });
                        }

                        // check if the drop down trigger option is hover on desktop view
                        if (settings.drop_down_trigger_out === 'hover') {
                            // li elements add hover function
                            $trigger.parent('li').on({
                                // mouseleave function
                                mouseleave: function () {
                                    // remove class active
                                    $(this).find($drop_down).stop(true, true).delay(settings.drop_down_delay_out).queue(function () {
                                        $(this).removeClass($active_class);
                                    });
                                    // remove active class on li
                                    $(this).stop(true, true).delay(settings.drop_down_delay_out).queue(function () {
                                        $(this).removeClass($active_drop_down_class);
                                    });
                                }
                            });
                        }

                    }
                };

                // drop down css transition for animation
                Canvas.prototype.drop_down_transition = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // apply css
                        //var liIndicator = $this.find('.liIndicator');
                        $trigger.css({
                            transition      : 'all ' + settings.drop_down_effect_speed + 'ms ease',
                            mozTransition   : 'all ' + settings.drop_down_effect_speed + 'ms ease',
                            webkitTransition: 'all ' + settings.drop_down_effect_speed + 'ms ease',
                            oTransition     : 'all ' + settings.drop_down_effect_speed + 'ms ease'
                        });
                    } else {
                        // apply css
                        $trigger.css({
                            transition      : 'none',
                            mozTransition   : 'none',
                            webkitTransition: 'none',
                            oTransition     : 'none'
                        });
                    }
                };

                // drop down indicator
                Canvas.prototype.drop_down_indicator = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // append the drop down indicator icon on desktop view
                        $drop_down_indicator.prev('a').append('<i class="fa fa-indicator ' + settings.drop_down_indicator_icon + '"></i>');
                    } else {
                        // check if the mobile view
                        // append the drop down indicator icon on mobile view
                        $trigger.prev('a').append('<i class="fa fa-indicator ' + settings.drop_down_indicator_icon_mobile + '"></i>');
                    }

                    // li drop down indicator
                    //if ($this.find('.liIndicator').length === 0) {
                    //    $li_active_class.append('<div class="liIndicator"></div>');
                    //}
                    if ($this.find('.ul_indicator').length === 0) {
                        $this.find('.drop-down.large>ul').append('<div class="ul_indicator"></div>');
                    }
                };

                // separator show or hide function
                Canvas.prototype.separator = function () {
                    // check if the separator show option is false on desktop view
                    if (settings.separator_show === false) {
                        // add class and hide the separator
                        $this.addClass($separator_hide_class);
                    } else {
                        // remove class and show the separator
                        $this.removeClass($separator_hide_class);
                    }
                };

                // top bar show border radius fix function
                Canvas.prototype.top_bar_radius = function () {
                    // check if the top bar show option is true
                    if (settings.top_bar_show === true) {
                        // add class border radius fix
                        $this.addClass($top_bar_radius_class);
                    } else {
                        // remove class
                        $this.removeClass($top_bar_radius_class);
                    }
                };

                // top bar show function
                Canvas.prototype.top_bar = function (desktop) {
                    // check if the desktop view
                    if (desktop === true) {
                        // check if the top bar show option is true on desktop view
                        if (settings.top_bar_show === true) {
                            // add class or show the top bar
                            $this.addClass($top_bar_show_class);
                        }
                    } else {
                        // check if the mobile view
                        // check if the top bar mobile option is true
                        if (settings.top_bar_show_mobile === true) {
                            // add class or show the top bar on mobile view
                            $this.addClass($top_bar_show_class);
                        }
                    }
                };

                // social icons align function
                Canvas.prototype.social_icons_Align = function () {
                    // check if the social icons align option is left on desktop view
                    if (settings.social_icons_align === 'left') {
                        // add class or align the icons left side
                        $this.addClass($social_icons_align_class);
                    } else {
                        // remove class align the icon  right side
                        $this.removeClass($social_icons_align_class);
                    }
                };

                // social icons function
                Canvas.prototype.social_icons_Hide = function (desktop) {
                    // check if is desktop view
                    if (desktop === true) {
                        // check if the social icons show is false on desktop view
                        if (settings.social_icons_show === false) {
                            // add class or hide the social icons
                            $this.addClass($social_icons_hide_class);
                        }
                    } else {
                        // mobile view
                        // check if the social icons show mobile option is false on mobile view
                        if (settings.social_icons_show_mobile === false) {
                            // add class ore hide the social icons
                            $this.addClass($social_icons_hide_class);
                        }
                    }
                };

                // menu elements effects
                Canvas.prototype.elementsEffects = function () {
                    // remove effect class function
                    var elements_effects_remove = function () {
                        $this.removeClass('sweep-to-right sweep-to-left sweep-to-top sweep-to-bottom bounce-to-right bounce-to-left bounce-to-top bounce-to-bottom radial-out rectangle-out shutter-out-horizontal shutter-out-vertical underline-from-left underline-from-center underline-from-right overline-from-left overline-from-center overline-from-right effect-fade');
                    };
                    // switch case. Add hover.css effects on menu elements
                    switch (settings.element_effects) {
                        case 'sweep-to-right':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('sweep-to-right');
                            break;
                        case 'sweep-to-left':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('sweep-to-left');
                            break;
                        case 'sweep-to-top':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('sweep-to-top');
                            break;
                        case 'sweep-to-bottom':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('sweep-to-bottom');
                            break;
                        case 'bounce-to-right':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('bounce-to-right');
                            break;
                        case 'bounce-to-left':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('bounce-to-left');
                            break;
                        case 'bounce-to-top':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('bounce-to-top');
                            break;
                        case 'bounce-to-bottom':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('bounce-to-bottom');
                            break;
                        case 'radial-out':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('radial-out');
                            break;
                        case 'rectangle-out':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('rectangle-out');
                            break;
                        case 'shutter-out-horizontal':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('shutter-out-horizontal');
                            break;
                        case 'shutter-out-vertical':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('shutter-out-vertical');
                            break;
                        case 'underline-from-left':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('underline-from-left');
                            break;
                        case 'underline-from-center':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('underline-from-center');
                            break;
                        case 'underline-from-right':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('underline-from-right');
                            break;
                        case 'overline-from-left':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('overline-from-left');
                            break;
                        case 'overline-from-center':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('overline-from-center');
                            break;
                        case 'overline-from-right':
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('overline-from-right');
                            break;

                        default:
                            elements_effects_remove(); // call effect remove class
                            $this.addClass('effect-fade');
                    }
                };

                // logo align function
                Canvas.prototype.logo_Align = function () {
                    // check if the logo align option is right on desktop view
                    if (settings.logo_align === 'right') {
                        // add class
                        $this.addClass($logo_align_class);
                    } else {
                        // remove class
                        $this.removeClass($logo_align_class);
                    }
                };

                // logo hide function
                Canvas.prototype.logo_hide = function (desktop) {

                    // check if the desktop view
                    if (desktop === true) {
                        // check if the logo show option is false then hide the logo on desktop
                        if (settings.logo_show === false) {
                            // add class
                            $this.addClass($logo_hide_class);
                        }
                    } else {
                        // check if the mobile view
                        // check if the logo show mobile option is false then hide the logo on mobile
                        if (settings.logo_show_mobile === false) {
                            // add class
                            $this.addClass($logo_hide_class);
                        }
                    }
                };

                // search bar hide function
                Canvas.prototype.search_bar = function () {
                    // check if the search bar show option is false on desktop view
                    if (settings.search_bar_show === false) {
                        // add class
                        $this.addClass($search_bar_hide_desktop);
                    } else {
                        // remove class
                        $this.removeClass($search_bar_hide_desktop);
                    }
                    // check if the search bar show mobile option is false on mobile view
                    if (settings.search_bar_show_mobile === false) {
                        // add class
                        $this.addClass($search_bar_hide_mobile);
                    } else {
                        // remove class
                        $this.removeClass($search_bar_hide_mobile);
                    }
                };

                // search bar align function
                Canvas.prototype.search_bar_Align = function () {
                    // check if the search bar align option is left on desktop view
                    if (settings.search_bar_align === 'left') {
                        // add class
                        $this.addClass($search_align_class);
                    } else {
                        // remove class
                        $this.removeClass($search_align_class);
                    }
                };

                // icons hide function
                Canvas.prototype.icons = function () {
                    // check if the icons show option is false on desktop view
                    if (settings.icons_show === false) {
                        // add class
                        $this.addClass($icons_hide_desktop);
                    } else {
                        // remove class
                        $this.removeClass($icons_hide_desktop);
                    }
                    // check if the icons show mobile option is false on mobile view
                    if (settings.icons_show_mobile === false) {
                        // add class
                        $this.addClass($icons_hide_mobile);
                    } else {
                        // remove class
                        $this.removeClass($icons_hide_mobile);
                    }
                };

                // destroy function
                Canvas.prototype.destroy = function () {
                    // remove class or show the logo
                    $this.removeClass($logo_hide_class);
                    // remove class social icons hide
                    $this.removeClass($social_icons_hide_class);
                    // remove class or hide the top bar
                    $this.removeClass($top_bar_show_class);
                    // remove the drop down indicator icon
                    $this.find('.fa-indicator').remove();
                    // drop down trigger hover
                    $trigger.parent('li').off('mouseenter').off('mouseleave');
                    $this.find($drop_down).stop(true, true).hide(0);
                    // drop down trigger click
                    $trigger.prev('a').off('click').off('mousedown');
                    $trigger.removeClass($active_class);
                    $li_active_class.removeClass($active_drop_down_class);
                    // off the window mouseup function
                    $(window).off('mouseup');
                    // off the window scroll function
                    $(window).off('scroll');
                    // sidebar
                    $profile_sidebar.show(0);
                    // profile
                    $profile_sidebar.off('click').off('mouseenter');
                    $profile.fadeOut(0);
                    // sticky header remove classes
                    $this.removeClass($sticky_header_desktop_class);
                };

                // media query function
                Canvas.prototype.mediaQuery = function (mediaQuery, current) {
                    // this variable
                    current = this;
                    // check media screen max width
                    mediaQuery = window.matchMedia("(max-width: 767px)");
                    // media query function
                    function media_query(property) {
                        // check if the media match
                        if (property.matches) {
                            // mobile view
                            // call functions
                            current.destroy();
                            current.logo_hide(false);
                            current.social_icons_Hide(false);
                            current.top_bar(false);
                            current.drop_down_indicator(false);
                            current.drop_down_trigger_hover(false);
                            current.drop_down_transition(false);
                            current.drop_down_trigger_click(false);
                            current.drop_down_trigger_mobile(false);
                            current.outside_click_close(false);
                            current.sidebar_Show(false);
                            current.sticky_header(false);
                        } else {
                            // desktop view
                            // call functions
                            current.destroy();
                            current.logo_hide(true);
                            current.social_icons_Hide(true);
                            current.top_bar(true);
                            current.drop_down_indicator(true);
                            current.drop_down_trigger_hover(true);
                            current.drop_down_transition(true);
                            current.drop_down_trigger_click(true);
                            current.drop_down_trigger_mobile(true);
                            current.outside_click_close(true);
                            current.sidebar_Show(true);
                            current.sticky_header(true);
                        }
                    }

                    // call media query function
                    media_query(mediaQuery);
                    // call media query function on windows resize
                    mediaQuery.addListener(media_query);
                };

                return Canvas;
            })();

            // call object
            $object = new Canvas();
            // call functions
            $object.search_bar();
            $object.icons();
            $object.elementsEffects();
            $object.logo_Align();
            $object.search_bar_Align();
            $object.social_icons_Align();
            $object.top_bar_radius();
            $object.separator();
            $object.ajax_form();
            $object.mobile_trigger();
            $object.drop_down_overflow();
            $object.mediaQuery();
        });
    };

    /*global $, jQuery, document*/
}(jQuery));