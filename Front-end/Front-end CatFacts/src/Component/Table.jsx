import React from 'react';

export const Table = ({ data }) => {
  return (
      <div className="table-responsive" style={{ maxHeight: '500px', overflowY: 'auto' }}>
          <table className="table table-sm table-bordered table-hover align-middle text-center">
              <thead className="table-dark">
                  <tr>
                      <th>#</th>
                      <th style={{ minWidth: '250px' }}>Frase</th>
                      <th>Palabra 1</th>
                      <th>Palabra 2</th>
                      <th>Palabra 3</th>
                      <th>GIF</th>
                      <th>Fecha</th>
                  </tr>
              </thead>
              <tbody>
                  {data.length === 0 ? (
                      <tr>
                          <td colSpan={7} className="text-center">No hay datos disponibles.</td>
                      </tr>
                  ) : (
                      data.map((row, index) => (
                          <tr key={row.id}>
                              <th scope="row">{index + 1}</th>
                              <td className="text-start small text-wrap" style={{ maxWidth: "300px" }}>
                                  {row.fact}
                              </td>
                              <td>{row.palabras?.[0]}</td>
                              <td>{row.palabras?.[1]}</td>
                              <td>{row.palabras?.[2]}</td>
                              <td>
                                  <img
                                      src={row.gifUrl}
                                      alt="gif"
                                      width="80"
                                      height="80"
                                      style={{ objectFit: 'cover', borderRadius: '8px' }}
                                  />
                              </td>
                              <td className="text-nowrap">{new Date(row.fechaBusqueda).toLocaleString()}</td>
                          </tr>
                      ))
                  )}
              </tbody>
          </table>
      </div>

  );
};
