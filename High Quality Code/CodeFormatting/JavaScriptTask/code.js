(function () {

    var theLayer,
        pX = 0,
        pY = 0,
        b = navigator.appName,
        addScroll = false;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (b == "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);    //Deprecated, consider changing!
    }

    function mouseMove(evn) {
        if (b == "Netscape") {
            pX = evn.pageX - 5;
            pY = evn.pageY;
        } else {
            pX = event.x - 5;
            pY = event.y;
        }

        if (b == "Netscape") {
            if (document.getElementsByClassName('ToolTip').visibility == 'show') {
                PopTip();
            }
        } else {
            if (document.getElementsByClassName('ToolTip').style.visibility == 'visible') {
                PopTip();
            }
        }
    }

    function PopTip() {
        if (b == "Netscape") {
            theLayer = eval('document.getElementsByClassName(\'ToolTip\')');

            if ((pX + 120) > window.innerWidth) {
                pX = window.innerWidth - 150;
            }

            theLayer.left = pX + 10;
            theLayer.top = pY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.getElementsByClassName(\'ToolTip\')');

            if (theLayer) {
                pX = event.x - 5;
                pY = event.y;

                if (addScroll) {
                    pX = pX + document.body.scrollLeft;
                    pY = pY + document.body.scrollTop;
                }

                if ((pX + 120) > document.body.clientWidth) {
                    pX = pX - 150;
                }

                theLayer.style.pixelLeft = pX + 10;
                theLayer.style.pixelTop = pY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {

        if (b == "Netscape") {
            document.getElementsByClassName('ToolTip').visibility = 'hide';
        }
        else {
            document.getElementsByClassName('ToolTip').style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {

        if (b == "Netscape") {
            theLayer = eval('.getElementById(\'menu1\')');
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.getElementById(\'menu1\')');
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu1() {

        if (b == "Netscape") {
            document.getElementById('menu1').visibility = 'hide';
        } else {
            document.getElementById('menu1').style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {

        if (b == "Netscape") {
            theLayer = eval('.getElementById(\'menu2\')');
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.getElementById(\'menu2\')');
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {

        if (b == "Netscape") {
            document.getElementById('menu2').visibility = 'hide';
        } else {
            document.getElementById('menu2').style.visibility = 'hidden';
        }
    }
}());