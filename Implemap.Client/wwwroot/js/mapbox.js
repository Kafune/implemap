
// todo: maybe move this somewhere sensible where it still has access to <head>

mapboxgl.accessToken = 'pk.eyJ1IjoidmlrdG9ydngiLCJhIjoiY2wyYWc5aWoyMDU4MDNpc2NpeHRhd3BnbiJ9.0ToPaRrFSK_tM7pZDZR2Ww';

var listings = [{
    "id": 2818,
    "latitude": 52.36435,
    "longitude": 4.94358,
    "name": "Quiet Garden View Room & Super Fast WiFi"
}, {
    "id": 1149694,
    "latitude": 52.38231,
    "longitude": 4.84866,
    "name": "Cosy city apartment"
}];

window.loadMapBox = () => {
    const map = new mapboxgl.Map({
        container: 'map', // container ID
        style: 'mapbox://styles/viktorvx/cl28zqp75000015pqm7dffov8', // style URL (also contains data layer)
        center: [4.90841, 52.3636], // starting position [lng, lat]
        zoom: 11 // starting zoom
    });

    listings.forEach(e => {
        console.log(e);
        const marker = new mapboxgl.Marker().setLngLat([e.longitude, e.latitude]).addTo(map);
        // use getElement to add an event
        marker.getElement().addEventListener('click', () => {
            alert(e.id + ": " + e.name);
        });
    });
}
