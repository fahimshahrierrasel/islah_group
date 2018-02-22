$(function () {
  $('[data-toggle="tooltip"]').tooltip()
});

//pie
var ctxP = document.getElementById("pieChart").getContext('2d');
var myPieChart = new Chart(ctxP, {
    type: 'pie',
    data: {
        labels: ["Red", "Green", "Yellow", "Grey", "Dark Grey","Green","Pink","Cain","Light Cain"],
        datasets: [
            {
                data: [300, 50, 100, 40, 120,100,10,250,210],
                backgroundColor: ["#F7464A", "#46BFBD", "#FDB45C", "#949FB1", "#4D5360","#bfff00","#00bfff","#ff00ff","#00ffbf"],
                hoverBackgroundColor: ["#FF5A5E", "#5AD3D1", "#FFC870", "#A8B3C5", "#616774","#c9ff26","#26c9ff","#ff4cff","#4cffd2"]
            }
        ]
    },
    options: {
        responsive: true
    }    
});