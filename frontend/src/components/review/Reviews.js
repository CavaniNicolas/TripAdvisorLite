
import { useState, useEffect } from 'react';
import Review from './Review.js'

function Reviews () {

	const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch((window.location.href).replace('3000','44398').replace('http','https'))
		.then(response => response.json())
		.then(json => setReviewData(json))
	  ,[]);
  
	let ReviewList = reviewData.map(review => <Review id={review.reviewId} userid={review.userId} serviceid={review.serviceId}
	  note={review.note} text={review.text} date={review.date}
	  key={review.reviewId}
	/>);

	const [menuClicked, setMenuClicked] = useState(null);
  	function ClickSort (what){
		const Sorter = (ReviewA, ReviewB) => {
			if(what === 'reviewid'){
				return (ReviewA.reviewId.toString().localeCompare(ReviewB.reviewId.toString()));
			}
			if(what === 'userid'){
				return (ReviewA.userId.toString().localeCompare(ReviewB.userId.toString()));
			}
			if(what === 'serviceid'){
				return (ReviewA.serviceId.toString().localeCompare(ReviewB.serviceId.toString()));
			}
			if(what === 'note'){
				return (ReviewA.note.toString().localeCompare(ReviewB.note.toString()));
			}
			if(what === 'text'){
				return (ReviewA.text.localeCompare(ReviewB.text));
			}
			if(what === 'date'){
				console.log('todo');
				return (ReviewA.date.localeCompare(ReviewB.date));
			}
		}
		setMenuClicked(what);
		setReviewData(reviewData.sort(Sorter));
	  }
	  
	function Arrow (what){
		if (what === menuClicked){
			return ' v';
		}
	}

    return (
		<div className="row">
		  <h1>reviews</h1>
		  <div className="col-1"onClick={() => ClickSort('reviewid') }>reviewid{Arrow('reviewid')}</div>
		  <div className="col-1"onClick={() => ClickSort('userid') }>userid{Arrow('userid')}</div>
		  <div className="col-1"onClick={() => ClickSort('serviceid') }>serviceid{Arrow('serviceid')}</div>
		  <div className="col-1"onClick={() => ClickSort('note') }>note{Arrow('note')}</div>
		  <div className="col-2"onClick={() => ClickSort('text') }>text{Arrow('text')}</div>
		  <div className="col-2"onClick={() => ClickSort('date') }>date{Arrow('date')}</div>
		  <h1> </h1>
		  {ReviewList}
		</div>
    );
}

export default Reviews;
