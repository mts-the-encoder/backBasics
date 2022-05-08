(async () => {

    //RUN
    const db = require("./db");
    console.log("começou");

    //INSERT
    console.log('INSERT INTO users');
    await db.insert({ name: "math", email: "m@bandtec.com.br" });

    //SELECT
    console.log('SELECT * FROM users');
    const [rows] = await db.select();
    console.log(rows);

    //UPDATE
    console.log('UPDATE users');
    const result = await db.update(2, { name: "matheus"})

    //DELETE
    console.log('DELETE FROM users');
    const result4 = await db.del(6);
    console.log(result4);
})();