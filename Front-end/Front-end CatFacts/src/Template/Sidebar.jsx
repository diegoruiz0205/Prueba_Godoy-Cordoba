import React from 'react';
// import logo_light from '../assets/img/kaiadmin/logo_light.svg';
import logo_light from '../assets/img/Logismart_original.png';

function Sidebar() {
    return (
        <>
            {/* <!-- Sidebar --> */}
            <div className="sidebar" data-background-color="dark">
                <div className="sidebar-logo">
                    {/* <!-- Logo Header --> */}
                    <div className="logo-header" data-background-color="dark">
                        
                        <div className="nav-toggle">
                            <button className="btn btn-toggle toggle-sidebar">
                                <i className="gg-menu-right"></i>
                            </button>
                            <button className="btn btn-toggle sidenav-toggler">
                                <i className="gg-menu-left"></i>
                            </button>
                        </div>
                        <button className="topbar-toggler more">
                            <i className="gg-more-vertical-alt"></i>
                        </button>
                    </div>
                    {/* <!-- End Logo Header --> */}
                </div>
                <div className="sidebar-wrapper scrollbar scrollbar-inner">
                    <div className="sidebar-content">
                        <ul className="nav nav-secondary">
                            <li className="nav-section">
                                <span className="sidebar-mini-icon">
                                    <i className="fa fa-ellipsis-h"></i>
                                </span>
                                <h4 className="text-section">Dashboard</h4>
                            </li>
                            <li className="nav-item">
                                <a data-bs-toggle="collapse" href="#base">
                                    <i className="fas fa-layer-group"></i>
                                    <p>Opciones</p>
                                    <span className="caret"></span>
                                </a>
                                <div className="collapse" id="base">
                                    <ul className="nav nav-collapse">
                                        <li>
                                            <a href="/fact">
                                                <span className="sub-item">Fact</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href="/historial">
                                                <span className="sub-item">Historial</span>
                                            </a>
                                        </li>
                                        
                                    </ul>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            {/* <!-- End Sidebar --> */}
        </>
    );
}

export default Sidebar;