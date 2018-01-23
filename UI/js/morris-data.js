$(function() {

    /*Morris.Area({
        element: 'morris-area-chart',
        data: [{
            period: '2017-07-01',
            iphone: 2666,
            ipad: null,
            itouch: 2647
        }, {
            period: '2017-07-02',
            iphone: 2778,
            ipad: 2294,
            itouch: 2441
        }, {
            period: '2017-07-04',
            iphone: 4912,
            ipad: 1969,
            itouch: 2501
        }, {
            period: '2017-07-05',
            iphone: 3767,
            ipad: 3597,
            itouch: 5689
        }, {
            period: '2017-07-06',
            iphone: 6810,
            ipad: 1914,
            itouch: 2293
        }, {
            period: '2017-07-09',
            iphone: 5670,
            ipad: 4293,
            itouch: 1881
        }, {
            period: '2017-07-10',
            iphone: 4820,
            ipad: 3795,
            itouch: 1588
        }, {
            period: '2017-07-11',
            iphone: 15073,
            ipad: 5967,
            itouch: 5175
        }, {
            period: '2017-07-12',
            iphone: 10687,
            ipad: 4460,
            itouch: 2028
        }, {
            period: '2017-07-13',
            iphone: 8432,
            ipad: 5713,
            itouch: 1791
        }],
        xkey: 'period',
        xLabels: "day",
        ykeys: ['iphone', 'ipad', 'itouch'],
        labels: ['iPhone', 'iPad', 'iPod Touch'],
        pointSize: 2,
        hideHover: 'auto',
        resize: true
    });*/

    Morris.Donut({
        element: 'morris-donut-chart',
        data: [{
            label: "Moradia",
            value: 2500
        }, {
            label: "Transporte",
            value: 1800
        }, {
            label: "Vestuário",
            value: 200
        }, {
            label: "Lazer",
            value: 800
        }],
        colors: ["#31C0BE","#c7254e","#98a0d3","#E8920C"],
        resize: true
    });

    Morris.Bar({
        element: 'morris-bar-chart',
        data: [{
            y: 'Jan',
            a: 5000
        }, {
            y: 'Fev',
            a: 7500
        }, {
            y: 'Mar',
            a: 5000
        }, {
            y: 'Abr',
            a: 7500
        }, {
            y: 'Mai',
            a: 5000
        }, {
            y: 'Jun',
            a: 7500
        }, {
            y: 'Jul',
            a: 10000
        }, {
            y: 'Ago',
            a: 1000
        }, {
            y: 'Set',
            a: 7000
        }, {
            y: 'Out',
            a: 0
        }, {
            y: 'Nov',
            a: 0
        }, {
            y: 'Dez',
            a: 0
        }],
        xkey: 'y',
        ykeys: ['a'],
        labels: ['Total gasto'],
        hideHover: 'auto',
        resize: true
    });

});
