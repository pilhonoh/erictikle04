var timeoutTimer;
var tempWeeklyId = "";

//tab menu
$(function () {
    //$("ul.tabs  li:first-child").addClass("tabs_on");
    //$("ul.mtabs li:first-child").addClass("mtabs_on");
    $(".tab_content").hide();
    $(".tab_content:first").show();

    $("ul.tabs li").click(function () {
        $("ul.tabs li").removeClass("tabs_on");
        $(this).addClass("tabs_on");
        $(".tab_content").hide();
        var activeTab = $(this).attr("rel");
        $("#" + activeTab).fadeIn();
    });
});


// �ֽ��ۼ��� ���ڵ��
$(function () {
    var allPanels = $('.accordion > dd').hide();
    //$('.accordion > dd:first-of-type').show();
    //$('.accordion > dt:first-of-type').addClass('accordion-active');
    //alert(tempWeeklyId);

    jQuery('.accordion > dt').on('click', function () {
        $this = $(this);
        if ($this.data('empty') == 'Y') return;
        //Mr.No
        //alert($this.data('weeklyid'));
        //var ff = $('.StandaloneView' + Number($this.data('weeklyid'))).contents().find('.type1').height();
        //alert(ff);


        $target = $this.next();
        
        if (!$this.hasClass('accordion-active')) {
            //$this.parent().children('dd').slideUp(); //slideUp / hide
            //jQuery('.accordion > dt').removeClass('accordion-active');
            $this.addClass('accordion-active');
            $target.addClass('active').slideDown();	 //slideDown / show  
            // Mr.No 2015-07-14 iframe
            var iframeHeight = $('.StandaloneView' + Number($this.data('weeklyid'))).contents().find('.type1').height();
            $('.StandaloneView' + Number($this.data('weeklyid'))).height(iframeHeight + 20); // Mr.No 2015-07-27 
        } else {
            //$this.parent().children('dd').slideUp(); //slideUp / hide
            //$('.accordion > dt').removeClass('accordion-active');
            $this.removeClass('accordion-active');
            $target.addClass('active').slideUp();
            
        }
        return false;
    });
});

//layer popup2
function layer_open(el) {
    
    //2015.08.10 zz17779 : ����/�ӿ� ����� ���Ӱ��� �˾� layer_absence �߰�
    $('#layer1, #layer2, #layer3, #layer4, #pop_email, #layer_absence, #pop_email_mailorgchart,#GatheringPop').css('display', 'none'); //�˾� ���̾� n����

    var temp = $('#' + el);

    var bg = temp.parents('bg');
    // MostiSoft - Weekly Note������ ��� ��� ���̰� �ϱ� ���� .bg || .bg2�� Ŭ������ ����.
    var bg2 = $('.bg').length == 0 ? $('.bg2') : $('.bg');

    if (el == "layer2") {
        bg2.removeClass('bg');
        bg2.addClass('bg2');
        $("input:checkbox[id='chkMailShare']").attr("checked", false);
    } else {
        bg2.removeClass('bg2');
        bg2.addClass('bg');
    }


    if (bg) {
        $('.layer').show();
    } else {
        temp.show();
    }

    temp.css('display', 'block');
    $('.btnArea.t_center').css('display', 'block');

    // MostiSoft - 
    // Weekly Note�� ��� �ϴ� / ���� ���� window ���� 5% �� �������� ���̵��� ����.
    // 5% �������� �˾��� ��� ������ ���� ������ 0px �������� ���̵��� ����.
    if (el == "layer2") {
        if ($.cookie("layer2") == "Y") {
            $("#layer2 .coachy_img").hide();
            $('#divRemark').hide();
        } else {
            CoachyOpen();
            $('#divRemark').show();
        }
        var iHeight = $(window).height() * 0.05;
        var iWidth = $(window).width() * 0.05;
        // window�� height�� �˾� ���� + window height�� 5% ���� Ŭ �� 
        if (temp.outerHeight() + iHeight < $(window).height()) {
            temp.css('top', 'auto');
            temp.css('bottom', '5%');
            temp.css('margin-top', '0px');
        }
            // window�� height�� �˾� ���� + window height�� 5% ���� ���� �� 
        else {
            temp.css('top', '0px');
            temp.css('margin-top', '0px');
            temp.css('bottom', 'auto');
        }

        // window�� width�� �˾� �ʺ� + window width�� 5% ���� Ŭ �� 
        if (temp.outerWidth() + iWidth < $(window).width()) {
            temp.css('left', '5%');
            temp.css('margin-left', '0px');
        }
            // window�� width�� �˾� �ʺ� + window width�� 5% ���� ���� �� 
        else {
            temp.css('left', '0px');
            temp.css('margin-left', '0px');
        }
    } else {

        if (temp.outerHeight() < $(document).height()) temp.css('margin-top', '-' + temp.outerHeight() / 2 + 'px');
        else temp.css('top', '0px');
        if (temp.outerWidth() < $(document).width()) temp.css('margin-left', '-' + temp.outerWidth() / 2 + 'px');
        else temp.css('left', '0px');
    }

    temp.find('a.cbtn').click(function (e) {
        if (bg) {
            $('.layer').hide();
            clearTimeout(timeoutTimer);
        } else {
            temp.hide();
            clearTimeout(timeoutTimer);
        }
        e.preventDefault();
    });

    /*
       Author : ������-������C, ������-������D
       Create Date : 2016.05.11 
       Desc : ���̾��˾� ������ ���� �ڵ� �ݱ� ����
    */
    $('.layer .bg').click(function (e) {
        //$('.layer').hide();
        clearTimeout(timeoutTimer);
        e.preventDefault();
    });

    // MostiSoft - bg2 Ŭ���ÿ��� �˾� �������� �߰�.
    $('.layer .bg2').click(function (e) {
        //$('.layer').hide();
        clearTimeout(timeoutTimer);
        e.preventDefault();
    });
}

// coachy mark 
$(function () {
    $("#coachy").click(function () {
        $("#layer2").append("<div class='coachy_img'></div>");
        timeoutTimer = setTimeout("testFunction()", 6000);
        //clearTimeout(timeoutTimer);
    });
});

function testFunction() {
    $(".coachy_img").fadeOut("slow", function () {
        $(".coachy_img").remove();
    });
}


