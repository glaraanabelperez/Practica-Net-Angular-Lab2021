fetch('https://rickandmortyapi.com/api/character')
  .then( request => {
      if (request.status == 200) {
          return request.text();
    } else {
      throw "Respuesta incorrecta del servidor" 
    }
  })
  .then( requestText => {
    let personajes = JSON.parse(responseText).results;
    console.log('Este es el objeto: ', personajes);
    info=personajes;

    for( i=0; i<info.length; i++){
            const lista = document.querySelector('#listaNombres');
            let div=document.createElement("div");
            div.innerHTML=`
            <ul>
                <li class="listaN">
                    <a style="text-decoration:none" onclick="inputName">
                    ${info[i].name}
                    </a>
                </li>
            </ul> 
            `
            lista.appendChild(div);
    }
  })

  .catch( err => {
    console.log(err);
  });
