import * as math from './modules/math.js';
import { stringLength, toUpperCase } from './modules/string.js';
console.log("String Length:", stringLength("Hello World"));
console.log("Uppercase:", toUpperCase("hello world"));
console.log("Add 5 + 3 =", math.add(5, 3));
console.log("Value of PI =", math.PI);
console.log("Square of 4 =", math.Calculator.square(4));