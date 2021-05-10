const VERSION = "1.0";
const APP = "TemporizadoresBlazor";
const CACHE_NAME = "CACHE_" + APP;
self.addEventListener('fetch', e => {

    const respuesta=caches.match(e.request).then(resp => {
        if (!resp) {
            //no existe la busco por internet
            resp = fetch(e.request).then(respuesta => {
                caches.open(CACHE_NAME).then(cache => cache.put(e.request, respuesta));
                return respuesta.clone();
            });
        }
        return resp;
    });

    e.respondWith(respuesta);
});