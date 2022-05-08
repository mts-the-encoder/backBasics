async function connect(){
    if(global.connection && global.connection.state !== 'disconnected')
        return global.connection;

    const mysql = require("mysql2/promise");
    const connection = await mysql.createConnection("mysql://root:urubu100@localhost:3306/teste");
    console.log("Conectou no MySQL!");
    global.connection = connection;
    return connection;
}

async function select() {
    const conn = await connect();
    return await conn.query('SELECT name FROM users');
}

async function insert(customer) {
    const conn = await connect();
    const sql = 'INSERT INTO users(name, email) VALUES (?,?);'
    const values = [customer.name, customer.email];
    await conn.query(sql, values);
}

async function update(id, customer) {
    const conn = await connect();
    const sql = 'UPDATE users SET name=? WHERE id=?';
    const values = [customer.name, id];
    await conn.query(sql, values);
}

async function del(id) {
    const conn = await connect();
    const sql = 'DELETE FROM users WHERE id=?'
    return await conn.query(sql, [id]);
}

module.exports = {select, insert, update, del}