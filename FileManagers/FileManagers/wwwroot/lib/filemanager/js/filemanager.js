document.addEventListener('alpine:init', () => {
    Alpine.data('data', () => ({
        _filemanager: [],

        init() {
            let url = "/filemanager/getalldir";
            fetch(url)
                .then(res => res.json())
                .then(json => {
                    this._filemanager = json
                });
        },

    }))
})