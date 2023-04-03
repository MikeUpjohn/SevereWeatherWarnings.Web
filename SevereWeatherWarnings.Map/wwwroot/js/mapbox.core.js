﻿let map;
const mapStyle = 'mapbox://styles/mikeupjohn/cleyos0o0000t01p9r4ovd33n';

function createMap(latitude, longitude, zoom) {
    if (map === undefined) {
        map = new mapboxgl.Map({
            container: 'map',
            style: mapStyle,
            center: [longitude, latitude],
            zoom: zoom
        });
    }
}

function addDataSourceToMap(id, coOrdinateList) {
    console.log(coOrdinateList);
    map.addSource(id, {
        'type': 'geojson',
        'data': {
            'type': 'Feature',
            'geometry': {
                'type': 'Polygon',
                'coordinates': coOrdinateList
            }
        }
    });
}

function drawPolygon(id, fillColourHex, fillOpacity) {
    map.addLayer({
        'id': id,
        'type': 'fill',
        'source': id,
        'layout': {},
        'paint': {
            'fill-color': fillColourHex,
            'fill-opacity': fillOpacity
        }
    });
}

function drawPolygonBorder(id, lineColourHex, lineThickness) {
    map.addLayer({
        'id': 'outline' + id,
        'type': 'line',
        'source': id,
        'layout': {},
        'paint': {
            'line-color': lineColourHex,
            'line-width': lineThickness
        }
    });
}