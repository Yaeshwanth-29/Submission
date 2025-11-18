module.exports = {
    testEnvironment: "jsdom",
 
    moduleFileExtensions: ["js", "jsx"],
 
    transform: {
 
      "^.+\\.[tj]sx?$": "babel-jest",
    },
 
    setupFilesAfterEnv: ["@testing-library/jest-dom"],
 
    collectCoverage: true,
 
    coverageReporters: ["text", "html"],
 
    collectCoverageFrom: [
        "src/**/*.{js,jsx}",             // include all JS/JSX files in src
        "!src/index.js",                 // exclude entry point if desired
      ],
 
    coverageThreshold: {
      global: {
        branches: 70,
        functions: 70,
        lines: 30,
        statements: 40
      }
    }
 
   
  };