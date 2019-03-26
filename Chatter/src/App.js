import React, {Component} from 'react';
import Navigation from './components/navigation';
import Jumbo from "./components/jumbo";
import Card from "./components/cards";
import Footer from "./components/footer";

class App extends Component {
    state = {
        news: [
            {
                "SourceName": "",
                "Author": "",
                "Title": "",
                "Description": "",
                "Url": "",
                "ImageUrl": "",
                "DatePublished": ""
            }
        ]
    };

    componentDidMount() {
        fetch("http://localhost:51563/api/news")
            .then(response => response.json())
            .then(json => this.setState({ news: json }));
    };

    render() {

        return (
            <>
                <Navigation/>
                <Jumbo news={this.state.news[0]}/>
                <div className={"card-parent"}>
                {
                    this.state.news.slice(1).map(item => (
                        <Card key={item.index} item={item}/>
                    ))
                }
                <Footer/>
                </div>
            </>
        );
    }
}

export default App;
