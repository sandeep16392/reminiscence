const mongoose = require('mongoose');

const Schema = mongoose.Schema;

const GenreSchema = new Schema({
    Name : String,
    Features: String
})

const Genre = mongoose.model('genre', GenreSchema);

module.exports = Genre;