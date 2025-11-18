const path = require('path');
const TerserPlugin = require('terser-webpack-plugin');

module.exports = (env, argv)=>{
    const isProd = argv.mode==='production';
    return{
  mode: 'argv.mode',
  entry: './src/index.ts',
  output: {
    filename: 'bundle.js',
    path: path.resolve(__dirname, 'dist'),
    clean:true
  },
  resolve: {
    extensions: ['.ts','.tsx','jsx','.js'],
  },
  module: {
    rules: [
      {
        test: /.(ts|tsx)$/,
        use: 'babel-loader',
        exclude: /node_modules/,
      },
    ],
  },
  optimization:isProd ? {
    minimize: true,
    minimizer: [new TerserPlugin({
        terserOptions:{
            compress:true,
            mangle:true,
            format:{
                comments:false
            }
        },
        extractComments:false
    })

]
  }
  :{},
  devtool:isProd?false:'source-map'
};
};
