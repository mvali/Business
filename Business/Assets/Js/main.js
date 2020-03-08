jQuery(function($) {'use strict',

	//#main-slider
	$(function(){
		$('#main-slider.carousel').carousel({
			interval: 8000
		});
	});

    $(document).ready(function(){
        $('.search-form').hover(function () {
            var pageWidth = $(document).width();
            if (pageWidth < 600) {
                $('.fa-search-front').css('width', '60px');
            } else {
                if (pageWidth < 700) { $('.fa-search-front').css('width', '140px'); }
                else {
                    $('.fa-search-front').css('width', '0px');
                }
            }
            
        }, function () {
            // on mouseout, reset the action
        });
    });

	// accordian
	$('.accordion-toggle').on('click', function(){
		$(this).closest('.panel-group').children().each(function(){
		$(this).find('>.panel-heading').removeClass('active');
		 });

	 	$(this).closest('.panel-heading').toggleClass('active');
	});

	// portfolio filter
	$(window).load(function(){'use strict';
		var $portfolio_selectors = $('.portfolio-filter >li>a');
		var $portfolio = $('.portfolio-items');
		$portfolio.isotope({
			itemSelector : '.portfolio-item',
			layoutMode : 'fitRows'
		});
		
		$portfolio_selectors.on('click', function(){
			$portfolio_selectors.removeClass('active');
			$(this).addClass('active');
			var selector = $(this).attr('data-filter');
			$portfolio.isotope({ filter: selector });
			return false;
		});
	});

	
	$(document).ready(function () {
	    //<!-- scroll -->
	    var defaults = {
	        containerID: 'toTop', // fading element id
	        containerHoverID: 'toTopHover', // fading element hover id
	        scrollSpeed: 1200,
	        easingType: 'linear'
	    };
	    $().UItoTop({ easingType: 'easeOutQuart' });

	    //<!-- scroll_top_btn -->
	    $(".scroll").click(function (event) {
	        event.preventDefault();
	        $('html,body').animate({ scrollTop: $("body").offset().top }, 500);
	    });

	    //Initiat WOW JS
	    new WOW().init();

	});



	//Pretty Photo
	$("a[rel^='prettyPhoto']").prettyPhoto({
		social_tools: false
	});	
});