import React from 'react';
import { Outlet } from 'react-router-dom';

function Content() {
    return (
        <>
            {/* Content */}
            <div className="container">
               <Outlet />
            </div>
            {/* End Content */}
        </>
    );
}

export default Content;