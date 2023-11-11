import React, { ReactNode } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';

interface LayoutProps {
	children: ReactNode
}

export function Layout(props: LayoutProps) {
	return (
		<div>
			<NavMenu />
			<Container tag="main">
				{props.children}
			</Container>
		</div>
	);
}
