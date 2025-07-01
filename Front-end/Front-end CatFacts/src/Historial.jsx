import React, { useEffect, useState } from 'react';
import { getHistory } from './Services/ApiServices';
import { Table } from './Component/Table';

export function Historial () {
     const [data, setData] = useState([]);

  useEffect(() => {
    const fetchHistory = async () => {
      try {
        const response = await getHistory();
        console.log("Historial recibido:", response.data);
        setData(response.data);
      } catch (error) {
        console.error("Error cargando historial:", error);
      }
    };

    fetchHistory();
  }, []);
    return (
        <>
            <div className="page-inner">
                <div className="page-header">
                    <h1 className="fw-bold mb-3"><strong>Historial</strong></h1>
                </div>
                <div className="row">
                    <div className="col-md-12">
                        <div className="card">
                            <div className="card-header">
                                <div className="card-title"><h2><strong>Busquedas</strong></h2></div>
                            </div>
                            <div className="card-body">
                                

                                {/* Componente */}
                                <Table data={data} />
                                {/* End Componente */}

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};