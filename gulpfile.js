const gulp = require("gulp");

gulp.task("hello", function(cb){
    console.log("Hello from Gulp!");
    cb();
});