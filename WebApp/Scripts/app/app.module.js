import {myExport} from '/modules/my-module.js';
// Define the `phonecatApp` module
angular.module('app', [
    // ...which depends on the `phoneList` module
    'phoneList'
  ]);