import React, { Component } from 'react';

interface FetchDataProps {}

interface FetchDataState {
	forecasts: Forecast[]
	loading: boolean
}

type Forecast = {
	date: string
	temperatureC: string
	temperatureF: string
	summary: string
}

export class FetchData extends Component<FetchDataProps, FetchDataState> {
	static displayName = FetchData.name;

	constructor(props: FetchDataProps) {
		super(props);
		this.state = { forecasts: [], loading: true };
	}

	componentDidMount() {
		this.populateWeatherData();
	}

	static renderForecastsTable(forecasts: Forecast[]) {
		return (
			<table className="table table-striped" aria-labelledby="tableLabel">
				<thead>
					<tr>
						<th>Date</th>
						<th>Temp. (C)</th>
						<th>Temp. (F)</th>
						<th>Summary</th>
					</tr>
				</thead>
				<tbody>
					{forecasts.map(forecast =>
						<tr key={forecast.date}>
							<td>{forecast.date}</td>
							<td>{forecast.temperatureC}</td>
							<td>{forecast.temperatureF}</td>
							<td>{forecast.summary}</td>
						</tr>
					)}
				</tbody>
			</table>
		);
	}

	render() {
		const contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.forecasts);

		return (
			<div>
				<h1 id="tableLabel">Weather forecast</h1>
				<p>This component demonstrates fetching data from the server.</p>
				{contents}
			</div>
		);
	}

	async populateWeatherData() {
		const response = await fetch('weatherforecast');
		const data = await response.json();
		this.setState({ forecasts: data, loading: false });
	}
}
