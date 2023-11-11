module.exports = {
	env: {
		browser: true,
		es2021: true,
	},
	extends: [
		'eslint:recommended',
		'plugin:@typescript-eslint/recommended',
		'plugin:react/recommended'
	],
	overrides: [
		{
			env: {
				node: true
			},
			files: [
				'.eslintrc.{js,cjs}'
			],
			parserOptions: {
				sourceType: 'script'
			}
		},
		{
			files: ['test/**'],
			env: {
				jest: true
			},
		}
	],
	parser: '@typescript-eslint/parser',
	parserOptions: {
		ecmaVersion: 'latest',
		sourceType: 'module'
	},
	plugins: [
		'@typescript-eslint',
		'react',
		'jest'
	],
	rules: {
		indent: [
			'error',
			'tab',
			{
				SwitchCase: 1,
				ignoredNodes: ['ConditionalExpression'],
			},
		],
		'quote-props': ['error', 'as-needed'],
		'linebreak-style': [
			'error',
			'unix'
		],
		quotes: [
			'error',
			'single'
		],
		semi: [
			'error',
			'always'
		],
		'react/prop-types': 'off',
		'@typescript-eslint/no-explicit-any': 'warn'
	},
	globals: {
		require: true,
		process: true,
		module: true,
		'jest/globals': true
	},
};
