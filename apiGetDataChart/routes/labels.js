const express = require('express');
const router = express.Router();
const mysql = require('../mysql').pool;

// conn.query(
//     "SELECT (_name) FROM _month"
// );

mysql.getConnection((error, conn) => {
    conn.query(
        "SELECT (_name) FROM _month"
    )
});

router.get('/', (req, res, next) => {
    mysql.getConnection((error, conn) => {
        if(error) { return res.status(500).send({ error: error }) }
        conn.query(
            'SELECT (_name) FROM _month;',
            (error, result, fields) => {
                if(error) { return res.status(500).send({ error: error }) } 
                return res.status(200).send({ response: result });
            }
        )
    }) 
});

router.post('/', (req, res, next) => {
    
    mysql.getConnection((error, conn) => {
        if(error) { return res.status(500).send({ error: error }) }
        conn.query(
            'INSERT INTO _month (_name) VALUES (?)',
            [req.body._name],
            (error, result, field) => {
                conn.release();
                if(error) { return res.status(500).send({ error: error }) }
                res.status(201).send({
                    message: 'Mounth create',
                    id: result.insertId
                });
            }
        )
    });
});

router.get('/:id', (req, res, next) => {
    mysql.getConnection((error, conn) => {
        if(error) { return res.status(500).send({ error: error }) }
        conn.query(
            'SELECT (_name) FROM _month WHERE id = ?;',
            [req.params.id],
            (error, result, fields) => {
                if(error) { return res.status(500).send({ error: error }) } 
                return res.status(200).send({ response: result });
            }
        )
    }) 
});

module.exports = router;