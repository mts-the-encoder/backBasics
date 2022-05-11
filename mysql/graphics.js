async function select() {
    const conn = await connect();
    return await conn.query('SELECT name FROM users');
}