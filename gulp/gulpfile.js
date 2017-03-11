/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

//https://docs.asp.net/en/latest/client-side/using-gulp.html 教程
var gulp = require('gulp');

var clean = require('gulp-clean');
var concat = require('gulp-concat');
var jshint = require('gulp-jshint');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');
var watch = require('gulp-watch');
gulp.task('default', function () {
    // place code for your default task here
});

gulp.task("watch", function () {
    gulp.watch("TypeScript/*.js", ['all']);
});
gulp.task("first", function () {
    console.log('first task! <-----');
});
gulp.task("all", function () {
    gulp.src('wwwroot/lib/*').pipe(clean());
    gulp.src(['TypeScript/Tastes.js', 'TypeScript/Food.js'])
    .pipe(concat("combined.js"))
    .pipe(jshint())
    .pipe(uglify())
    .pipe(rename({
        extname: '.min.js'
    }))
    .pipe(gulp.dest('wwwroot/lib'))
});