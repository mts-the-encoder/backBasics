const express = require('express');
const router = express.Router();
const mysql = require('../mysql').pool;

mysql.getConnection((error, conn) => {
    conn.query(
        'SELECT * FROM tb_log'
    );
});

router.get('/', (req, res, next) => {
    mysql.getConnection((error, conn) => {
        if(error) { return res.status(500).send({ error: error }) }
        conn.query(
            'select * from tb_log;',
            (error, result, fields) => {
                if(error) { return res.status(500).send({ error: error }) } 
                return res.status(200).send(result);
            }
        )
    }) 
});

router.get('/:id', (req, res, next) => {
    mysql.getConnection((error, conn) => {
        if(error) { return res.status(500).send({ error: error }) }
        conn.query(
            'SELECT (memoria_uso) FROM tb_log WHERE id = ?;',
            [req.params.id],
            (error, result, fields) => {
                if(error) { return res.status(500).send({ error: error }) } 
                return res.status(200).send({ response: result });
            }
        )
    }) 
});

module.exports = router;