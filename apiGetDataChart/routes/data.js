// const express = require('express');
// const router = express.Router();
// const mysql = require('../mysql').pool;

// mysql.getConnection((error, conn) => {
//     conn.query(
//         "SELECT * FROM sales"
//     )
// });

// router.get('/', (req, res, next) => {
//     mysql.getConnection((error, conn) => {
//         if(error) { return res.status(500).send({ error: error }) }
//         conn.query(
//             'SELECT * FROM sales;',
//             (error, result, fields) => {
//                 if(error) { return res.status(500).send({ error: error }) } 
//                 return res.status(200).send(result);
//             }
//         )
//     }) 
// });

// router.post('/', (req, res, next) => {
    
//     mysql.getConnection((error, conn) => {
//         if(error) { return res.status(500).send({ error: error }) }
//         conn.query(
//             'INSERT INTO sales (sale) VALUES (?)',
//             [req.body.sale],
//             (error, result, field) => {
//                 conn.release();
//                 if(error) { return res.status(500).send({ error: error }) }
//                 res.status(201).send({
//                     message: 'Sale create',
//                     id: result.insertId
//                 });
//             }
//         )
//     });
// });

// router.get('/:id', (req, res, next) => {
//     mysql.getConnection((error, conn) => {
//         if(error) { return res.status(500).send({ error: error }) }
//         conn.query(
//             'SELECT (sale) FROM sales WHERE id = ?;',
//             [req.params.id],
//             (error, result, fields) => {
//                 if(error) { return res.status(500).send({ error: error }) } 
//                 return res.status(200).send({ response: result });
//             }
//         )
//     }) 
// });

// module.exports = router;