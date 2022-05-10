const mysql = require('mysql2');

var con = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'urubu100',
    database: 'chart'
});

con.connect(function (err) {
    if (err) throw err;
    console.log('conectado');
    var sql = 'SELECT (sale) FROM sales';
    con.query(sql, (err, result) => {
        if (err) throw err;
        console.log('hello');
        return console.log(result);
    });
});
