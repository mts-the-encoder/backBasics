const mysql = require('mysql');

var pool = mysql.createPool({
    "user": "root",
    "password": "urubu100",
    "database": "chart",
    "host": "localhost",
    "port": 3306
});

exports.pool = pool;