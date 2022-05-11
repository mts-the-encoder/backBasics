const mysql = require('mysql');

var pool = mysql.createPool({
    "user": "aluno",
    "password": "sptech",
    "database": "Overload",
    "host": "localhost",
    "port": 3306
});

exports.pool = pool;