
document.onkeydown = function (e) {
    e = e || window.event;
    if (e.keyCode == 27) {   // on escape buttom

        if ($('.itemlisting .pop').hasClass('open')) {
            closeInfoPopup()
        }

        if ($('body').hasClass('openmenu')) {
            closemenu()
        }
        if ($('body').hasClass('opendropdownmenu')) {
            closeDropdownMenu()
        }
       
    }
   
}







//_________________________________________________________________

if (!/Android|webOS|iPhone|iPod|iPad|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {   // desktop only
    $('body').addClass('desktop');
}

if (navigator.appVersion.indexOf("Win") != -1) {  // windows only
    $('body').addClass('windows');
}
if ($(document).height() > $(window).height()) {  // detect if page contain scroll
    $('body').addClass('containVscroll');
}
$(window).resize(function () {
    if ($(document).height() > $(window).height()) {
        $('body').addClass('containVscroll');
    } else {
        $('body').removeClass('containVscroll');
    }
})
//_________________________________________________________________




// website menu

function openmenu() {
    $('body').addClass('openmenu');
}

function closemenu() {
    $('body').removeClass('openmenu');
}



// dropdown menu in header


$('header .link[name],footer .link[name]').click(function (event) {
     var obj = this;
     var getname = $(this).attr('name');
     
     if (!$('.dropdownmenu[name = "' + getname + '"]').hasClass('open')) {
         closeDropdownMenu();
         $('.dropdownmenu[name = "' + getname + '"]').addClass('open');
         $('header .menu>li').eq(1).find('.link').addClass('selected2');
         $('body').addClass('opendropdownmenu');
     } else {
         closeDropdownMenu();
     }
     event.stopPropagation();
});

$('#wrapper').click(function () {
    if ($('body').hasClass('opendropdownmenu')) {
        closeDropdownMenu()
    }
});

$('.dropdownmenu').click(function (event) {
    event.stopPropagation();
});

function closeDropdownMenu() {
    $('.dropdownmenu').removeClass('open');
    $('body').removeClass('opendropdownmenu');
    $('header .link').removeClass('selected2');
}




$(window).load(function () {
    wow = new WOW({
        mobile: false,
        offset: $(window).height() / 6
    })
    wow.init();
});




function booknow() {
    $('.Book .custbtn').addClass('loading');
    setTimeout(function () {
        $('.Book .custbtn').removeClass('loading');
        $('.Book .txmssg').addClass('open');
        $('.Book .holder').addClass('hidden');
        $('html,body').animate({ scrollTop: $('.Book .txmssg .mssgwrap').offset().top - $(window).height() / 2 })
    }, 2333)
    setTimeout(function () {
        $('.Book .txmssg').removeClass('open');
        $('.Book .holder').removeClass('hidden');
    },6333)
}



function subscribe() {
    $('.subscribePopup .custbtn').addClass('loading');
    setTimeout(function () {
        $('.subscribePopup .custbtn').removeClass('loading');
        $('.subscribePopup .txmssg').fadeIn();
        $('.subscribePopup .inner').hide();
    }, 2333)
    setTimeout(function () {
        $('.subscribePopup .txmssg').hide();
        $('.subscribePopup .inner').fadeIn();
    }, 6333)
}


function sendrequest() {
    $('.bookPopup .custbtn').addClass('loading');
    setTimeout(function () {
        $('.bookPopup .custbtn').removeClass('loading');
        $('.bookPopup .txmssg').fadeIn();
        $('.bookPopup .inner').hide();
    }, 2333)
    setTimeout(function () {
        $('.bookPopup .txmssg').hide();
        $('.bookPopup .inner').fadeIn();
    }, 6333)
}


function submitquestion() {
    $('.askQuestion .custbtn').addClass('loading');
    setTimeout(function () {
        $('.askQuestion .custbtn').removeClass('loading');
        $('.askQuestion .txmssg').fadeIn();
        $('.askQuestion .inner').hide();
    }, 2333)
    setTimeout(function () {
        $('.askQuestion .txmssg').hide();
        $('.askQuestion .inner').fadeIn();
    }, 6333)
}




// start phone-flags plugin
//________________________________________________________________________

if ($('#phone1').length != 0) {
    var input = document.querySelector("#phone1");
    window.intlTelInput(input, {
        // allowDropdown: false,
        // autoHideDialCode: false,
        // autoPlaceholder: "off",
        // dropdownContainer: document.body,
        // excludeCountries: ["us"],
        // formatOnDisplay: false,
        // geoIpLookup: function(callback) {
        //   $.get("http://ipinfo.io", function() {}, "jsonp").always(function(resp) {
        //     var countryCode = (resp && resp.country) ? resp.country : "";
        //     callback(countryCode);
        //   });
        // },
        // hiddenInput: "full_number",
        initialCountry: "lb",
        // localizedCountries: { 'de': 'Deutschland' },
        // nationalMode: false,
        // onlyCountries: ['us', 'gb', 'ch', 'ca', 'do'],
        // placeholderNumberType: "MOBILE",
        // preferredCountries: ['cn', 'jp'],
        separateDialCode: true,
        utilsScript: "scripts/utils.js",
    });
}


if ($('#phone2').length != 0) {
    var input = document.querySelector("#phone2");
    window.intlTelInput(input, {
        // allowDropdown: false,
        // autoHideDialCode: false,
        // autoPlaceholder: "off",
        // dropdownContainer: document.body,
        // excludeCountries: ["us"],
        // formatOnDisplay: false,
        // geoIpLookup: function(callback) {
        //   $.get("http://ipinfo.io", function() {}, "jsonp").always(function(resp) {
        //     var countryCode = (resp && resp.country) ? resp.country : "";
        //     callback(countryCode);
        //   });
        // },
        // hiddenInput: "full_number",
        initialCountry: "lb",
        // localizedCountries: { 'de': 'Deutschland' },
        // nationalMode: false,
        // onlyCountries: ['us', 'gb', 'ch', 'ca', 'do'],
        // placeholderNumberType: "MOBILE",
        // preferredCountries: ['cn', 'jp'],
        separateDialCode: true,
        utilsScript: "scripts/utils.js",
    });
}

if ($('#phone3').length != 0) {
    var input = document.querySelector("#phone3");
    window.intlTelInput(input, {
        // allowDropdown: false,
        // autoHideDialCode: false,
        // autoPlaceholder: "off",
        // dropdownContainer: document.body,
        // excludeCountries: ["us"],
        // formatOnDisplay: false,
        // geoIpLookup: function(callback) {
        //   $.get("http://ipinfo.io", function() {}, "jsonp").always(function(resp) {
        //     var countryCode = (resp && resp.country) ? resp.country : "";
        //     callback(countryCode);
        //   });
        // },
        // hiddenInput: "full_number",
        initialCountry: "lb",
        // localizedCountries: { 'de': 'Deutschland' },
        // nationalMode: false,
        // onlyCountries: ['us', 'gb', 'ch', 'ca', 'do'],
        // placeholderNumberType: "MOBILE",
        // preferredCountries: ['cn', 'jp'],
        separateDialCode: true,
        utilsScript: "scripts/utils.js",
    });
}



if ($('#phone4').length != 0) {
    var input = document.querySelector("#phone4");
    window.intlTelInput(input, {
        // allowDropdown: false,
        // autoHideDialCode: false,
        // autoPlaceholder: "off",
        // dropdownContainer: document.body,
        // excludeCountries: ["us"],
        // formatOnDisplay: false,
        // geoIpLookup: function(callback) {
        //   $.get("http://ipinfo.io", function() {}, "jsonp").always(function(resp) {
        //     var countryCode = (resp && resp.country) ? resp.country : "";
        //     callback(countryCode);
        //   });
        // },
        // hiddenInput: "full_number",
        initialCountry: "lb",
        // localizedCountries: { 'de': 'Deutschland' },
        // nationalMode: false,
        // onlyCountries: ['us', 'gb', 'ch', 'ca', 'do'],
        // placeholderNumberType: "MOBILE",
        // preferredCountries: ['cn', 'jp'],
        separateDialCode: true,
        utilsScript: "scripts/utils.js",
    });
}



// swiper-article page

var picslide;
function initpicslide() {
    if ($('.picslide').length != 0) {
        picslide = new Swiper('.picslide .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 566,
            loop: true,
            pagination: {
                el: '.picslide .swiper-pagination',
                type: 'bullets',
                clickable: true
            },
        });
    }
}


initpicslide();




// fixed website buttoms
function detectposition() {
    if ($('.Options').length != 0) {
        if ($(window).scrollTop() + $(window).height() > ($(document).height() - $('footer').height())) {
            $('.Options').addClass('move');
        } else {
            $('.Options').removeClass('move');
        }
    }

}

detectposition();

$(window).scroll(function () {
    detectposition();

})




// tabs menu (treatments page)

var tabmenu;
function initTabmenu() {
    if ($('.tabmenu').length != 0) {
        tabmenu = new Swiper('.tabmenu .screen', {
            slidesPerView:'auto',
            watchOverflow: true,
            speed: 566,
            loop: false,
            centerInsufficientSlides: true,
        });
    }
}

initTabmenu();

$('.tabmenu .link').click(function () {
    $('.tabmenu .link').removeClass('selected');
    $(this).addClass('selected');
    tabmenu.slideTo($('.tabmenu .selected').parents('.swiper-slide').index());
})









// mobile info popup (treatment page)
$('.itemlisting .item .pic').click(function () {
    if ($('.isresponsive').is(':visible')) {
        $(this).parents('.item').find('.pop').addClass('open');
    }
});

function closeInfoPopup() {
    $('.itemlisting .pop').removeClass('open');
}

$('.itemlisting .cloze').click(function () {
    
    closeInfoPopup();
});

$('.itemlisting .pop').click(function () {
    if ($('.isresponsive').is(':visible')) {
        if ($(this).hasClass('open')) {
            closeInfoPopup();
        }
    }
});

$('.itemlisting .in').click(function (event) {
    if ($('.isresponsive').is(':visible')) {
        event.stopPropagation();
    }
});






// top slider in blog page

var subslide;
function initsubslide() {
    if ($('.subslide').length != 0) {
        subslide = new Swiper('.subslide .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 566,
            //autoplay: {
            //    delay: 5000,
            //    disableOnInteraction: false,
            //},
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            },
            loop: false,
            pagination: {
                el: '.subslide .swiper-pagination',
                type: 'bullets',
                clickable: true
            },
        });
    }
}


initsubslide();





// Trending swiper

var trendingswipe;
function initTrendingswipe() {
    if ($('.featured').length != 0) {
        trendingswipe = new Swiper('.featured .screen', {
            slidesPerView:1,
            watchOverflow: true,
            speed: 566,
            loop: false,
            spaceBetween:3,
            pagination: {
                el: '.featured .swiper-pagination',
                type: 'bullets',
                clickable: true
            },
        });
    }
}

initTrendingswipe();







// sponsors swiper, about page

var sponsorSwipe;
function initsponsorSwipe() {
    if ($('.Sponsors').length != 0) {
        sponsorSwipe = new Swiper('.Sponsors .screen', {
            slidesPerView: 'auto',
            watchOverflow: true,
            speed: 566,
            loop: false,
            centerInsufficientSlides: true,
        });
    }
}

initsponsorSwipe();




// brand swiper, home-page

var brandsSwipe;
function initbrandsSwipe() {
    if ($('.brandSection').length != 0) {
        brandsSwipe = new Swiper('.brandSection .screen', {
            slidesPerView: 'auto',
            watchOverflow: true,
            speed: 566,
            loop: false,
            centerInsufficientSlides: true,
        });
    }
}

initbrandsSwipe();

$('.brandSection .item').click(function () {
    $('.brandSection .item').removeClass('selected')
    $(this).addClass('selected')
    brandsSwipe.slideTo($(this).parents('.swiper-slide').index())
});




// articles swiper (at end of about page)

var itemSwipe;
function inititemSwipe() {
    if ($('.otheritems').length != 0) {
        itemSwipe = new Swiper('.otheritems .screen', {
            slidesPerView: 'auto',
            watchOverflow: true,
            speed: 566,
            loop: false,
            scrollbar: {
                el: ".otheritems .swiper-scrollbar",
                hide: false,
                draggable: true,
            },
        });
    }
}

inititemSwipe();





// sub-menu (blog page, about page)

var secondmenu;
function initsecondmenu() {
    if ($('.secondmenu').length != 0) {
        secondmenu = new Swiper('.secondmenu .screen', {
            slidesPerView: 'auto',
            watchOverflow: true,
            speed: 566,
            loop: false,
            breakpoints: {
                10: {
                    centerInsufficientSlides: false,
                },
                768: {
                    centerInsufficientSlides: true,
                }
            }
        });
    }
}

initsecondmenu();


$('.secondmenu .link').click(function () {
    $('.secondmenu .link').removeClass('selected')
    $(this).addClass('selected')
    secondmenu.slideTo($(this).parents('.swiper-slide').index() - 1)
})



// scroll inside about page

if ($('.aboutsections').length != 0) {
    $('.secondmenu .link').click(function () {
        $('html,body').animate({ scrollTop: $('.subsection').eq($(this).parents('.swiper-slide').index()).offset().top - 61 })
    });
}





// transformation swiper (before/after)

var transformswiper;
function initTransformswiper() {
    if ($('.Transform').length != 0) {
        transformswiper = new Swiper('.Transform .screen', {
            slidesPerView:1,
            watchOverflow: true,
            speed: 766,
            loop: true,
            spaceBetween:22,
            navigation: {
                nextEl: '.Transform .custnext',
                prevEl: '.Transform .custprev',
            },
        });
    }
}

initTransformswiper();


// faq swiper

var faqswiper;
function initfaq() {
    if ($('.faq').length != 0) {
        faqswiper = new Swiper('.faq .screen', {
            watchOverflow: true,
            loop: false,
            spaceBetween: 0,
            navigation: {
                nextEl: '.faq .custnext',
                prevEl: '.faq .custprev',
            },
            breakpoints: {
                10: {
                    slidesPerView: 1,
                    slidesPerGroup: 1,
                    slidesPerColumn: 2,
                    speed: 500,
                    allowTouchMove: true,
                },
                768: {
                    slidesPerView: 2,
                    slidesPerGroup: 2,
                    slidesPerColumn: 1,
                    speed: 0,
                    allowTouchMove: false,
                }
            },
            
        });
    }
}

initfaq();






// Our experts Swiper

var expertSwiper;
function initexpertSwiper() {
    if ($('.ourteam').length != 0) {
        expertSwiper = new Swiper('.ourteam .screen', {
            slidesPerView: 'auto',
            spaceBetween: 0,
            watchOverflow: true,
            centeredSlides: true,
            initialSlide: $('.ourteam .swiper-slide').length / 2,
            speed: 666,
            loop: false,
            scrollbar: {
                el: ".ourteam .swiper-scrollbar",
                draggable: true,
            },
        });
    }
}

initexpertSwiper();





// slideshow - homepage

var slideswiper;
function initslideswiper() {
    if ($('.Slideshow').length != 0) {
        slideswiper = new Swiper('.Slideshow .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 566,
            autoplay: {
                delay: 5000,
                disableOnInteraction: false,
            },
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            },
            loop: true,
            pagination: {
                el: '.Slideshow .swiper-pagination',
                type: 'bullets',
                clickable: true
            },
        });


        if ($('.desktop').length == 0) {
            $('.Slideshow .pic img').css('height', $(window).height() - $('header').height());
        }

    }
}


initslideswiper();




// products Swiper - homepage


let productInstances = [];

function initprdswipe() {
    if ($('.ourproducts').length != 0) {

        $(".ourproducts .screen").each(function (index, element) {
            const $this = $(this);
            $this.addClass("instance-prd" + index);
            $this.parents('.ourproducts').find(".swiper-pagination").addClass("pagination-" + index);
            productInstances[index] = new Swiper(".instance-prd" + index, {
                slidesPerView: 'auto',
                spaceBetween: 0,
                watchOverflow: true,
                speed: 666,
                loop: false,
                pagination: {
                    el: ".pagination-" + index,
                    type: 'bullets',
                    clickable: true
                },

            })

        });

    }
}


initprdswipe();








// desktop double blog swiper homepage


var anim1;
var anim2;

function initdoubleSwiper() {

    if ($('.animation1').length != 0) {
        anim1 = new Swiper('.animation1 .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 766,
            loop: true,
            spaceBetween: 20,
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            },
            on: {
                slideChange: function () {
                    setTimeout(function () {
                        anim2.slideTo($('.animation1 .swiper-slide-active').index())
                    }, 33);
                },

            },
        });
    }


    if ($('.animation2').length != 0) {
        anim2 = new Swiper('.animation2 .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 766,
            loop: true,
            spaceBetween: 20,
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            },
            navigation: {
                nextEl: '.desktop_blogswiper .custnext',
                prevEl: '.desktop_blogswiper .custprev',
            },
            on: {
                slideChange: function () {
                    setTimeout(function () {
                        anim1.slideTo($('.animation2 .swiper-slide-active').index())
                    }, 33);
                },

            },
        });
    }

}

initdoubleSwiper();






// mobile-blog swiper - homepage

var blogmobileSwiper;
function initblogmobileSwiper() {
    if ($('.mob_blogswiper').length != 0) {
        blogmobileSwiper = new Swiper('.mob_blogswiper .screen', {
            slidesPerView: 1,
            watchOverflow: true,
            speed: 766,
            loop: true,
            spaceBetween: 20,
            navigation: {
                nextEl: '.mob_blogswiper .custnext',
                prevEl: '.mob_blogswiper .custprev',
            },
        });
    }
}

initblogmobileSwiper();

//Dany
function switchType(id) {
    $(".typeOption").removeClass("selected");
    $("#Type_" + id).addClass("selected");

    $(".ServiceListing").removeClass("selected");
    $("#forType_" + id).addClass("selected");

}
