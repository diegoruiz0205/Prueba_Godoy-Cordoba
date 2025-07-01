import { useEffect, useState } from "react";
import { getGifRandom } from "./Services/ApiServices";

export function Fact() {
    const [factData, setFactData] = useState({});
    const [cambiar, setCambiar] = useState(0);

    useEffect(() => {
        const getGif = async () => {
            try {
                const response = await getGifRandom(1);
                console.log(" GIF recibido:", response.data);
                setFactData(response.data); // ✅ Guarda el objeto completo
            } catch (error) {
                console.log(" Error:", error);
            }
        };

        getGif();
    }, [cambiar]);

    return (
        <>
            <div className="page-inner">
                <div className="page-header">
                    <h1 className="fw-bold mb-3"><strong>Cat Fact</strong></h1>
                </div>
                <div className="row">
                    <div className="col-md-12">
                        <div className="card">
                            <div className="card-header">
                                <div className="card-title"><h1><strong>Actualizar GIF</strong></h1></div>
                            </div>
                            <div className="card-body">

                                <div className="card-body d-flex flex-column justify-content-center align-items-center"
                                    style={{ minHeight: "70vh" }}
                                >
                                    <div className="row align-items-center justify-content-center w-100">
                                        {/* GIF */}
                                        <div className="col-md-5 text-center mb-4 mb-md-0">
                                            {factData.gifUrl ? (
                                                <img
                                                    src={factData.gifUrl}
                                                    alt="gif aleatorio"
                                                    className="rounded shadow"
                                                    style={{ maxWidth: "300px", height: "auto", objectFit: "cover" }}
                                                />
                                            ) : (
                                                <div className="spinner-border text-primary" role="status">
                                                    <span className="visually-hidden">Cargando...</span>
                                                </div>
                                            )}
                                        </div>

                                        {/* Texto */}
                                        <div className="col-md-7 text-center text-md-start">
                                            <h2 className="mb-4 fw-bold text-primary">GIF Aleatorio</h2>
                                            <h4 className="fw-bold mb-3">Frase:</h4>
                                            <p
                                                className="mb-3"
                                                style={{
                                                    maxWidth: "100%",
                                                    fontSize: "30px",
                                                    fontWeight: "500",
                                                    lineHeight: "1.8",
                                                }}
                                            >
                                                {factData.fact}
                                            </p>

                                            <div className="text-center text-md-start">
                                                <button
                                                    className="btn btn-primary px-4 mt-2"
                                                    onClick={() => setCambiar(cambiar + 1)}
                                                >
                                                     ACTUALIZAR GIF
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>


                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
}
