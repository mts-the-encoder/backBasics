const Sequelize = require('sequelize');

const sequelize = new Sequelize("dbmts", "root",  "urubu100", {
    host: 'localhost',
    dialect: 'mysql'
});

sequelize.authenticate()
    .then(() => {
        console.log('Conexão criada com sucesso');
    }).catch( () => {
        console.log('Erro');
    });

module.exports = sequelize;