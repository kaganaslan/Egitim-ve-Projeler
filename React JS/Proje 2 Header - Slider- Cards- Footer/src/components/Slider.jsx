import React from 'react'

function Slider() {
  return (
    <div>
        <div id="carouselExample" className="carousel slide">
  <div className="carousel-inner">
    <div className="carousel-item active">
      <img src="https://seyler.ekstat.com/img/max/800/C/CymIir8aGaYAdLCZ-636777082402643254.jpg" className="d-block w-100" alt="..." style={{height:"500px"}} />
    </div>
    <div className="carousel-item">
      <img src="https://seyler.ekstat.com/img/max/800/C/CymIir8aGaYAdLCZ-636777082402643254.jpg" className="d-block w-100" alt="..." style={{height:"500px"}} />
    </div>
    <div className="carousel-item">
      <img src="https://seyler.ekstat.com/img/max/800/C/CymIir8aGaYAdLCZ-636777082402643254.jpg" className="d-block w-100" alt="..." style={{height:"500px"}} />
    </div>
  </div>
  <button className="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
    <span className="carousel-control-prev-icon" aria-hidden="true" />
    <span className="visually-hidden">Previous</span>
  </button>
  <button className="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
    <span className="carousel-control-next-icon" aria-hidden="true" />
    <span className="visually-hidden">Next</span>
  </button>
</div>


    </div>
  )
}

export default Slider