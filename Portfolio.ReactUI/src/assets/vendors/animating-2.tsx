import React from "react";


export default class PageTransitions extends React.Component {

    isAnimating: boolean = false;
    endCurrentPage: boolean = true;
    endNextPage: boolean = false;
    animEndEventNames = {
        'WebkitAnimation': 'webkitAnimationEnd',
        'OAnimation': 'oAnimationEnd',
        'msAnimation': 'MSAnimationEnd',
        'animation': 'animationend'
    };

    init(options: string) {

        //var menu = options.menu,
    }


    


    render() {
        return (
            <div>
                <h1>Page Transitions</h1>
            </div>
        )
    }
};