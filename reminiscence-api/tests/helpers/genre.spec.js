const Genre = require('../../models/Genre');
const mongoose = require('mongoose');
const expect = require('chai').expect;

let genre;
before((done) => {
    // mongoose.connection.collections.genres.drop(() => {

    //     done();
    // });
    mongoose.connect('mongodb://localhost/reminiscence_test');
    mongoose.connection
    .once('open', ()=> {
        console.log('Database Started!')
        
    })
    .on('error', (error) => {
        console.warn('Warning', error);
    });

    done();
});

describe('Genre Test', (done)=>{
    
    it('Save Test', (done)=>{
        const genreNature = new Genre({Name: 'Nature Photography', Features: 'Test Feature'});

        genreNature.save().then(()=>{
            expect(genreNature.isNew).to.be.false;
        });
        done();

    });

    it('Read Test', (done)=>{
        const genreNature = new Genre({Name: 'Nature Photography', Features: 'Test Feature'});

        Genre.find({Name: 'Nature Photography'}).then((genres)=>{
            genres.forEach((genre)=>{
                expect(genre.Name).to.be.equal('Nature Photography');
                expect(genre.Features).to.be.equal('Test Feature');
            });
        });
        done();

    });

    it('Read Test - Find One', (done)=>{
        const genreNature = new Genre({Name: 'Nature Photography', Features: 'Test Feature'});

        Genre.findOne({Name: 'Nature Photography'}).then((genre)=>{
                expect(genre.Name).to.be.equal('Nature Photography');
                expect(genre.Features).to.be.equal('Test Feature');
        });
        done();

    });

    it('Read Test - Find One', (done)=>{
        const genreNature = new Genre({Name: 'Nature Photography', Features: 'Test Feature'});
        
        Genre.findOne({Name: 'Animal Photography'}).then((genre)=>{
                expect(genre).to.be.null;
        });
        done();

    });

    it('Read Test - Remove One', (done)=>{
        const genreNature = new Genre({Name: 'Nature Photography', Features: 'Test Feature'});
        
        // genreNature.save().then().then(
            Genre.deleteOne({Name: "Nature Photography"})
                .then(()=>{
                    Genre.findOne({Name: "Nature Photography"})
                        .then((g)=>{
                            expect(g).to.be.null;
                        });
            })
        // )

        Genre.findOne({Name: 'Animal Photography'}).then((genre)=>{
                expect(genre).to.be.null;
        });
        done();

    });

    it('Update - set and update', (done)=>{
        const genre = new Genre({Name: 'Wildlife Photography', Features: 'Test Feature'});

        // genre.save().then(()=>{
        //     console.log(genre);
        //     genre.set('Name', "Test").save();
        //     console.log(genre);
        // });

        Genre.updateMany({Name: "Wildlife Photography"}, {Name: "Test"}).then(()=>{
            Genre.findOne({Name:"Test"}, (g)=>{
                expect(g).not.to.be.null;
            })
        });
        done();
        
    })
});
