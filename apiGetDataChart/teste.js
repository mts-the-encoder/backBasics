var dataRam = [];

async function getData() {
    var response = await (await fetch ('http://localhost:8000/ram')).json();
    dataRam = [];
    dataRam.push(await response.forEach((data) => {
        if(data) {
            dataRam.push(data.porcentagem_memoria_ram_uso);
        }
    }));
    dataRam.pop();
    return dataRam;
}
var idRam = document.getElementById('chart-ram');
async function plotRam(idRam) {
    await getData();
    var ctxRam = document.getElementById('chart-ram').getContext('2d');
    var myChartRam = new Chart(ctxRam, {
        type: 'line',
        data: {
            labels: ['a', 'b', 'c', 'd', 'e'],
            datasets: [{
                label: 'RAM',
                data: dataRam,
                backgroundColor: [backG],
                borderColor: [bordG],
                borderWidth: 3
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}