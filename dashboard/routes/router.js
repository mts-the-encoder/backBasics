const express = require('express')
const {principalView} = require('../controllers/pageController'); 
const router = express.Router();

router.get('/', principalView);

module.exports = {routes: router}