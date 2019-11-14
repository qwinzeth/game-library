import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

class ReviewRow extends React.Component {
	render() {
		return (
			<tr>
				<td>{this.props.review.GameTitle}</td>
				<td class='right-align-text'>{this.props.review.RatingOf100}</td>
				<td>{this.props.review.ReviewerName}</td>
			</tr>
		);
	}
}

class ReviewList extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			reviews: []
		};
	}
	
	async componentDidMount() {
		/* TODO: fetch from API
		const response = await fetch('');
		const myJson = await response.json();
		console.log(JSON.stringify(myJson));*/
		this.setState({reviews: 
			[
				{GameTitle: "Game1", RatingOf100: 90, ReviewerName: "Some Guy"},
				{GameTitle: "Game2", RatingOf100: 87, ReviewerName: "Nobody"}
			]});
	}
	
	renderReview(review) {
		return <ReviewRow review={review} />;
	}
	
	render() {
		return (
			<table>
				<thead>
					<tr>
						<th>Game</th>
						<th>Rating</th>
						<th>Reviewer</th>
					</tr>
				</thead>
				<tbody>
					{
						this.state.reviews.map((review) =>
							this.renderReview(review))
					}
				</tbody>
			</table>
		);
	}
}

ReactDOM.render(
	<ReviewList />,
	document.getElementById('root')
);