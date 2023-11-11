import React from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './index.scss';

function App() {
	return (
		<Layout>
			<div className="App">
				<header className="App-header">
					<Routes>
						{AppRoutes.map((route, index) => {
							const { element, ...rest } = route;
							return <Route key={index} {...rest} element={element} />;
						})}
					</Routes>
					<a
						className="App-link"
						href="https://reactjs.org"
						target="_blank"
						rel="noopener noreferrer"
					>
					Learn React
					</a>
				</header>
			</div>
		</Layout>
	);
}

export default App;

