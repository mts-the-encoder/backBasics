const express = require('express');
const path = require('path');
const exppressLayouts = require('express-ejs-layouts');
const expressLayouts = require('express-ejs-layouts');

const app = express();

app.set('view engine', 'ejs');
app.use(expressLayouts);

// minimiza paths - ajuda;
app.use(express.static(path.join(__dirname, 'public')));

const router = require('./routes/router');
app.use(router.routes);


// app.get('/', (req, res) => {
//     res.send('Dashboard w/ node.js');
// });

app.listen(3001, () => {
    console.log('run on http://localhost:3001');
});