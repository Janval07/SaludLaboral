<template>
  <div class="bloque-titulo">
    <h1>I. FACTORES CONDICIONANTES B&Aacute;SICOS</h1>
  </div>
  <div class="contenedor">
    <br />
    <form
      action="http://localhost:8080/Proyecto_SaludLaboral/ServletGuardarRespuestas"
      method="post"
    >
      <!-- Página 1 -->
      <div class="pagina" id="pagina1">
        <fieldset class="fieldset">
          <legend>Descriptivos de la Persona</legend>

          <label for="folio" class="label">Folio:</label>
          <input type="text" id="folio" name="folio" class="input" required /><br /><br />

          <label for="fecha" class="label">Fecha:</label>
          <input type="date" id="fecha" name="fecha" class="input" required />
          <br /><br />

          <label for="nombre" class="label">Nombre:</label>
          <input type="text" id="nombre" name="nombre" class="input" required />
          <br /><br />

          <label for="apellidos" class="label">Apellidos:</label>
          <input type="text" id="apellidos" name="apellidos" class="input" required />
          <br /><br />

          <label for="edad" class="label">Edad:</label>
          <input type="number" id="edad" name="edad" class="input" required /><br /><br />

          <label for="sexo" class="label">Sexo:</label>
          <select id="sexo" name="sexo" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Masculino">Masculino</option>
            <option value="Femenino">Femenino</option>
            <option value="Prefiero no Contestar">Prefiero no Contestar</option></select
          ><br /><br />

          <label for="estadocivil" class="label">Estado Civil:</label>
          <select id="estadocivil" name="estadocivil" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Soltero">Soltero</option>
            <option value="Casado">Casado</option>
            <option value="Divorciado">Divorciado</option>
            <option value="Union Libre">Union Libre</option>
            <option value="Viudo">Viudo</option>
            <option value="Otro">Otro</option></select
          ><br /><br />

          <label for="escolaridad" class="label">Escolaridad:</label>
          <select id="escolaridad" name="escolaridad" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Prescolar">Prescolar</option>
            <option value="Primaria">Primaria</option>
            <option value="Secundaria">Secundaria</option>
            <option value="Media Superior">Media Superior</option>
            <option value="Superior">Superior</option>
            <option value="Otro">Otro</option></select
          ><br /><br />

          <label for="empresa" class="label">Empresa:</label>
          <input type="text" id="empresa" name="empresa" class="input" required /><br /><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton-completo" onclick="mostrarPagina(2)">
            <span class="flecha">&#x25B6;</span> Siguiente
          </button>
        </div>
      </div>
      <!-- Página 2 -->
      <div class="pagina" id="pagina2" style="display: none">
        <fieldset class="fieldset">
          <legend>
            Caracter&iacute;sticas del &aacute;rea de trabajo y valoraci&oacute;n del trabajo
          </legend>

          <p class="label">1. Le gustar&iacute;a que sus hijos trabajaran en lo mismo que usted:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.1Si"
            name="P1"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.1Si">SI</label>
          <input id="P1.1No" name="P1" type="radio" value="0" />
          <label for="P1.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            2. Le da satisfacci&oacute;n la realizaci&oacute;n de sus actividades:
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.2Si"
            name="P2"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.2Si">SI</label>
          <input id="P1.2No" name="P2" type="radio" value="0" />
          <label for="P1.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">3. Est&aacute; interesado en su trabajo:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.3Si"
            name="P3"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.3Si">SI</label>
          <input id="P1.3No" name="P3" type="radio" value="0" />
          <label for="P1.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">4. Su trabajo le permite desarrollar sus habilidades y destrezas:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.4Si"
            name="P4"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.4Si">SI</label>
          <input id="P1.4No" name="P4" type="radio" value="0" />
          <label for="P1.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">5. Su trabajo le permite desarrollar su creatividad e iniciativa:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.5Si"
            name="P5"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.5Si">SI</label>
          <input id="P1.5No" name="P5" type="radio" value="0" />
          <label for="P1.5No">NO</label><br />&nbsp;&nbsp;

          <p class="label">6. Su trabajo le permite el aprendizaje de nuevos conocimientos:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.6Si"
            name="P6"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.6Si">SI</label>
          <input id="P1.6No" name="P6" type="radio" value="0" />
          <label for="P1.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">7. Puede usted decidir sobre c&oacute;mo realizar su trabajo:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.7Si"
            name="P7"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.7Si">SI</label>
          <input id="P1.7No" name="P7" type="radio" value="0" />
          <label for="P1.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">8. Puede usted fijar el ritmo de trabajo:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.8Si"
            name="P8"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.8Si">SI</label>
          <input id="P1.8No" name="P8" type="radio" value="0" />
          <label for="P1.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            9. Sus compa&ntilde;eros son solidarios con usted y valoran su trabajo:
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.9Si"
            name="P9"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.9Si">SI</label>
          <input id="P1.9No" name="P9" type="radio" value="0" />
          <label for="P1.9No">NO</label><br />&nbsp;&nbsp;

          <p class="label">10. Su trabajo es importante para sus jefes:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.10Si"
            name="P10"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.10Si">SI</label>
          <input id="P1.10No" name="P10" type="radio" value="0" />
          <label for="P1.10No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            11. Falto al trabajo en los &uacute;ltimos 12 meses
            <mark>(si la respuesta es no, pase al siguiente apartado)</mark>:
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P1.11Si"
            name="P11"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P1.11Si">SI</label>
          <input id="P1.11No" name="P11" type="radio" value="0" />
          <label for="P1.11No">NO</label><br />&nbsp;&nbsp;

          <label for="P1.12" class="label"
            >12. En cuantas ocasiones distintas falt&oacute; al trabajo en los &uacute;ltimos 12
            meses (independientemente de cuantos d&iacute;as hayan sido en cada
            ocasi&oacute;n):</label
          >
          &nbsp;&nbsp;
          <select id="P1.12" name="P12" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Nunca">Nunca</option>
            <option value="Ocasionalmente">Ocasionalmente</option>
            <option value="Frecuentemente">Frecuentemente</option>
            <option value="Muy frecuentemente">Muy frecuentemente</option></select
          ><br /><br />

          <label for="P1.13" class="label"
            >13. En cuantas de esas ocasiones fue por motivo de salud:</label
          >
          &nbsp;&nbsp;
          <select id="P1.13" name="P13" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Ninguna">Ninguna</option>
            <option value="Algunas">Algunas</option>
            <option value="La mayoria">La mayor&iacute;a</option>
            <option value="Todas">Todas</option></select
          ><br /><br />

          <label for="P1.14" class="label"
            >14. Cuantos d&iacute;as del a&ntilde;o en total falto por motivos de salud:</label
          >
          &nbsp;&nbsp;
          <select id="P1.14" name="P14" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Ningun d&iacute;a">Ningun d&iacute;a</option>
            <option value="Menos de 7 d&iacute;as">Menos de 7 d&iacute;as</option>
            <option value="Mas de 7 dias">M&aacute;s de 7 d&iacute;as</option>
            <option value="Mas de 15 dias">M&aacute;s de 15 d&iacute;as</option>
            <option value="Mas de 23 dias">M&aacute;s de 23 d&iacute;as</option>
            <option value="Mas de un mes">M&aacute;s de un mes</option>
          </select>
          <br /><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(1)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(3)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 3 -->
      <div class="pagina" id="pagina3" style="display: none">
        <fieldset class="fieldset">
          <legend>Factores del sistema Familiar</legend>

          <label for="rolfamiliar" class="label">Rol que ocupa en la familia:</label>
          <select id="rolfamiliar" name="P15" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Padre">Padre</option>
            <option value="Madre">Madre</option>
            <option value="Hijo">Hijo</option>
            <option value="Esposa/o">Esposa/o</option>
            <option value="Otro">Otro</option>
          </select>
          <br /><br />

          <label for="numerohijos" class="label">¿Cu&aacute;ntos hijos tiene?</label>
          <select id="numerohijos" name="P16" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Ninguno">Ninguno</option>
            <option value="Un hijo">Un hijo</option>
            <option value="Dos hijos">Dos hijos</option>
            <option value="Tres hijos">Tres hijos</option>
            <option value="Mas de cuatro">M&aacute;s de cuatro</option></select
          ><br /><br />

          <label for="relacfamiliar" class="label">Relaci&oacute;n con la familia:</label>
          <select id="relacfamiliar" name="P17" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Buena">Buena</option>
            <option value="Regular">Regular</option>
            <option value="Mala">Mala</option>
          </select>
          <br /><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(2)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(4)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 4 -->
      <div class="pagina" id="pagina4" style="display: none">
        <fieldset class="fieldset">
          <legend>Factores socioculturales y econ&oacute;micos</legend>

          <label for="P3.1" class="label">1. &Aacute;rea o departamento donde trabaja:</label>
          <input type="text" id="P3.1" name="P18" class="input" required /> <br /><br />

          <label for="P3.2" class="label">2. Puesto que ocupa actualmente:</label>
          <input type="text" id="P3.2" name="P19" class="input" required /> <br /><br />

          <label for="P3.3" class="label">3. Cu&aacute;nto tiempo lleva en la empresa</label>
          <select id="P3.3" name="P20" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Menos de un a&ntilde;o">Menos de un a&ntilde;o</option>
            <option value="De 1 a 2 a&ntilde;os">De 1 a 5 a&ntilde;os</option>
            <option value="De 3 a 4 a&ntilde;os">De 6 a 10 a&ntilde;os</option>
            <option value="Mas de 5 a&ntilde;os">M&aacute;s de 10 a&ntilde;os</option>
          </select>
          <br /><br />

          <p class="label">4. Es trabajador de:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P3.4confianza"
            name="P21"
            type="radio"
            value="confianza"
            checked="checked"
          />
          <label for="P3.4confianza">Confianza</label>
          <input id="P3.4sindicalizado" name="P21" type="radio" value="sindicalizado" />
          <label for="P3.4sindicalizado">Sindicalizado</label> <br /><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(3)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(5)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 5 -->
      <div class="pagina" id="pagina5" style="display: none">
        <fieldset class="fieldset">
          <legend>Estado y sistema de salud</legend>
          <p class="import">
            Responder las preguntas tomando en cuenta los &uacute;ltimos 12 meses
          </p>

          <p class="label">1. ¿Le zumban los o&iacute;dos?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.1Si"
            name="P22"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.1Si">SI</label>
          <input id="P4.1No" name="P4.1" type="radio" value="0" />
          <label for="P4.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">2. ¿Durante el &uacute;ltimo a&ntilde;o ha notado que oye menos?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.2Si"
            name="P23"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.2Si">SI</label>
          <input id="P4.2No" name="P23" type="radio" value="0" />
          <label for="P4.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            3. ¿Tiene dificultad para o&iacute;r a sus compa&ntilde;eros de trabajo a m&aacute;s de
            un metro de distancia aunque no haya mucho ruido?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.3Si"
            name="P24"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.3Si">SI</label>
          <input id="P4.3No" name="P4.3" type="radio" value="0" />
          <label for="P4.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">4. ¿Ha tenido molestias a la luz normal durante varios d&iacute;as?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.4Si"
            name="P25"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.4Si">SI</label>
          <input id="P4.4No" name="P25" type="radio" value="0" />
          <label for="P4.4No">NO</label><br />&nbsp;&nbsp;

          <label for="P4.5" class="label"
            >5. Con qu&eacute; frecuencia se le irritan los ojos durante varios d&iacute;as</label
          >
          &nbsp;&nbsp;
          <select id="P4.5" name="P26" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="0">NUNCA</option>
            <option value="0">CASI NUNCA</option>
            <option value="0">DE VEZ EN CUANDO</option>
            <option value="1">A MENUDO</option>
            <option value="1">MUY A MENUDO</option></select
          ><br />

          &nbsp;&nbsp;
          <p class="label">
            6. ¿Le han llorado los ojos o a tenido comez&oacute;n o ardor en varias ocasiones?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.6Si"
            name="P27"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.6Si">SI</label>
          <input id="P4.6No" name="P27" type="radio" value="0" />
          <label for="P4.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            7. Sin tener basura ¿ Frecuentemente ha tenido sensaci&oacute;n de basura en los ojos en
            varias ocasiones?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.7Si"
            name="P28"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.7Si">SI</label>
          <input id="P4.7No" name="P28" type="radio" value="0" />
          <label for="P4.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            8. ¿Ha tenido laga&ntilde;as constantes o supuraci&oacute;n en los ojos?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.8Si"
            name="P29"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.8Si">SI</label>
          <input id="P4.8No" name="P29" type="radio" value="0" />
          <label for="P4.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            9. ¿Durante el &uacute;ltimo a&ntilde;o tuvo anginas con fiebre alta m&aacute;s de dos
            veces?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.9Si"
            name="P30"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.9Si">SI</label>
          <input id="P4.9No" name="P30" type="radio" value="0" />
          <label for="P4.9No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            10. ¿Durante el &uacute;ltimo a&ntilde;o ha tenido m&aacute;s de cuatro catarros?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.10Si"
            name="P31"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.10Si">SI</label>
          <input id="P4.10No" name="P31" type="radio" value="0" />
          <label for="P4.10No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            11. ¿Ha tenido escurrimiento o secreci&oacute;n de la nariz de mal olor y color verdoso?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.11Si"
            name="P32"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.11Si">SI</label>
          <input id="P4.11No" name="P32" type="radio" value="0" />
          <label for="P4.11No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            12. ¿Ha tenido congesti&oacute;n y/o dolor a los lados de la nariz o en la frente?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.12Si"
            name="P33"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.12Si">SI</label>
          <input id="P4.12No" name="P33" type="radio" value="0" />
          <label for="P4.12No">NO</label><br />&nbsp;&nbsp;

          <p class="label">13. ¿Estas molestias han durado m&aacute;s de 15 d&iacute;as?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.13Si"
            name="P34"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.13Si">SI</label>
          <input id="P4.13No" name="P34" type="radio" value="0" />
          <label for="P4.13No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            14. ¿Ha tenido tos en el &uacute;ltimo a&ntilde;o?
            <mark>Si la respuesta es NO, pase a la pregunta 17</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.14Si"
            name="P35"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.14Si">SI</label>
          <input id="P4.14No" name="P35" type="radio" value="0" />
          <label for="P4.14No">NO</label><br />&nbsp;&nbsp;

          <p class="label">15. En este caso ¿fue tos con flemas?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.15Si" name="P36" type="radio" value="1" />
          <label for="P4.15Si">SI</label>
          <input id="P4.15No" name="P36" type="radio" value="0" checked="checked" />
          <label for="P4.15No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            16. ¿Ha tosido tres meses seguidos o m&aacute;s en el &uacute;ltimo a&ntilde;o?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.16Si" name="P37" type="radio" value="1" />
          <label for="P4.16Si">SI</label>
          <input id="P4.16No" name="P37" type="radio" value="0" checked="checked" />
          <label for="P4.16No">NO</label><br />&nbsp;&nbsp;

          <p class="label">17. ¿Se le reseca la piel frecuentemente?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.17Si"
            name="P38"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.17Si">SI</label>
          <input id="P4.17No" name="P38" type="radio" value="0" />
          <label for="P4.17No">NO</label><br />&nbsp;&nbsp;

          <p class="label">18. ¿Tiene ardor o comez&oacute;n en la piel?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.18Si"
            name="P39"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.18Si">SI</label>
          <input id="P4.18No" name="P39" type="radio" value="0" />
          <label for="P4.18No">NO</label><br />&nbsp;&nbsp;

          <p class="label">19. ¿Le salen ampollas en alguna parte de su cuerpo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.19Si"
            name="P40"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.19Si">SI</label>
          <input id="P4.19No" name="P40" type="radio" value="0" />
          <label for="P4.19No">NO</label><br />&nbsp;&nbsp;

          <p class="label">20. ¿Tiene piel con escamas en alguna parte de su cuerpo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.20Si"
            name="P41"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.20Si">SI</label>
          <input id="P4.20No" name="P41" type="radio" value="0" />
          <label for="P4.20No">NO</label><br />&nbsp;&nbsp;

          <p class="label">21. ¿Le han salido frecuentemente granos con agua o pus o ronchas?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.21Si"
            name="P42"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.21Si">SI</label>
          <input id="P4.21No" name="P42" type="radio" value="0" />
          <label for="P4.21No">NO</label><br />&nbsp;&nbsp;

          <p class="label">22. ¿Se le agrieta parte de la piel?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.22Si"
            name="P43"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.22Si">SI</label>
          <input id="P4.22No" name="P43" type="radio" value="0" />
          <label for="P4.22No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            23. ¿Ha sufrido alg&uacute;n accidente de trabajo durante el &uacute;ltimo a&ntilde;o?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.23Si"
            name="P44"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.23Si">SI</label>
          <input id="P4.23No" name="P44" type="radio" value="0" />
          <label for="P4.23No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            24. ¿Ha sufrido alg&uacute;n accidente en trayecto durante el &uacute;ltimo a&ntilde;o?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.24Si"
            name="P45"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.24Si">SI</label>
          <input id="P4.24No" name="P45" type="radio" value="0" />
          <label for="P4.24No">NO</label><br />&nbsp;&nbsp;

          <p class="label">25. ¿Frecuentemente tiene dificultad para conciliar el sue&ntilde;o?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.25Si"
            name="P46"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.25Si">SI</label>
          <input id="P4.25No" name="P46" type="radio" value="0" />
          <label for="P4.25No">NO</label><br />&nbsp;&nbsp;

          <p class="label">26. Con frecuencia ¿Tiene sue&ntilde;o intranquilo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.26Si"
            name="P47"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.26Si">SI</label>
          <input id="P4.26No" name="P47" type="radio" value="0" />
          <label for="P4.26No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            27. ¿Se despierta pocas horas despu&eacute;s de haberse dormido y ya no se puede volver
            a dormir?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.27Si"
            name="P48"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.27Si">SI</label>
          <input id="P4.27No" name="P48" type="radio" value="0" />
          <label for="P4.27No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            28 ¿Ha tenido dolor de cabeza m&aacute;s de dos veces por mes?
            <mark>Si la respuesta es NO, pase a la pregunta 34</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.28Si"
            name="P49"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.28Si">SI</label>
          <input id="P4.28No" name="P49" type="radio" value="0" />
          <label for="P4.28No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            29. ¿El dolor de cabeza se presenta cuando est&aacute; nervioso o irritable?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.29Si" name="P50" type="radio" value="1" />
          <label for="P4.29Si">SI</label>
          <input id="P4.29No" name="P50" type="radio" value="0" checked="checked" />
          <label for="P4.29No">NO</label><br />&nbsp;&nbsp;

          <p class="label">30. ¿El dolor de cabeza es tan fuerte que le impide trabajar?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.30Si" name="P51" type="radio" value="1" />
          <label for="P4.30Si">SI</label>
          <input id="P4.30No" name="P51" type="radio" value="0" checked="checked" />
          <label for="P4.30No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            31. ¿Est&aacute; acompa&ntilde;ado de n&aacute;usea o v&oacute;mito, mareo o
            visi&oacute;n borrosa?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.31Si" name="P52" type="radio" value="1" />
          <label for="P4.31Si">SI</label>
          <input id="P4.31No" name="P52" type="radio" value="0" checked="checked" />
          <label for="P4.31No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            32. ¿Antes de que aparezca el dolor tiene sensaciones que le avisan que va a aparecer?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.32Si" name="P53" type="radio" value="1" />
          <label for="P4.32Si">SI</label>
          <input id="P4.32No" name="P53" type="radio" value="0" checked="checked" />
          <label for="P4.32No">NO</label><br />&nbsp;&nbsp;

          <p class="label">33. ¿El dolor se presenta solo en un lado de la cabeza?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P4.33Si" name="P54" type="radio" value="1" />
          <label for="P4.33Si">SI</label>
          <input id="P4.33No" name="P54" type="radio" value="0" checked="checked" />
          <label for="P4.33No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            34. En el &uacute;ltimo a&ntilde;o, en caso de haber padecido dolor que le haya
            dificultado laborar, ¿En qu&eacute; parte del cuerpo fue?
          </p>
          <input type="checkbox" id="P4.34" name="P55" value="1" />
          <label for="P4.34">CUELLO</label><br />

          <input type="checkbox" id="P4.35" name="P56" value="1" />
          <label for="P4.35">HOMBROS, CODOS MU&Ntilde;ECAS O MANOS</label><br />

          <input type="checkbox" id="P4.36" name="P57" value="1" />
          <label for="P4.36">ESPALDA, CINTURA, CADERA ASENTADERAS</label><br />

          <input type="checkbox" id="P4.37" name="P58" value="1" />
          <label for="P4.37">MUSLOS, RODILLAS, TOBILLOS O PIES</label><br />&nbsp;&nbsp;

          <p class="label">38. ¿Ha tenido mucho dolor en la parte baja de la espalda?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.38Si"
            name="P59"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.38Si">SI</label>
          <input id="P4.38No" name="P59" type="radio" value="0" />
          <label for="P4.38No">NO</label><br />&nbsp;&nbsp;

          <p class="label">39. ¿En caso afirmativo el dolor se corre a la pierna?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.39Si"
            name="P60"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.39Si">SI</label>
          <input id="P4.39No" name="P60" type="radio" value="0" />
          <label for="P4.39No">NO</label><br />&nbsp;&nbsp;

          <p class="label">40. ¿Ha tenido varices en las piernas?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.40Si"
            name="P61"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.40Si">SI</label>
          <input id="P4.40No" name="P61" type="radio" value="0" />
          <label for="P4.40No">NO</label><br />&nbsp;&nbsp;

          <p class="label">41. ¿Durante el &uacute;ltimo a&ntilde;o ha tenido hemorroides?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P4.41Si"
            name="P62"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P4.41Si">SI</label>
          <input id="P4.41No" name="P62" type="radio" value="0" />
          <label for="P4.41No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            Durante el &uacute;ltimo a&ntilde;o le ha diagnosticado un m&eacute;dico alguna
            enfermedad.¿Cu&aacute;l?
          </p>
          <label for="P4.0" class="label"></label>
          <input type="text" id="P4.0" name="P63" class="input" />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(4)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(6)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 6 -->
      <div class="pagina" id="pagina6" style="display: none">
        <div class="bloque-titulo">
          <h1>II. REQUISITOS DE AUTOCUIDADO UNIVERSALES</h1>
        </div>
        <br />

        <fieldset class="fieldset">
          <legend>FAGERSTRÖM</legend>

          <p class="label">
            3) ¿Cu&aacute;nto tiempo transcurre desde que Ud. Despierta hasta que fuma el primer
            cigarrillo?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P5.3.2"
            name="P66"
            type="radio"
            value="3"
            checked="checked"
          />
          <label for="P5.3.2">Menos de 5 min</label>
          <input id="P5.3.3" name="P66" type="radio" value="2" />
          <label for="P5.3.3">6-30 min</label>
          <input id="P5.3.4" name="P66" type="radio" value="1" />
          <label for="P5.3.4">31-60 min</label>
          <input id="P5.3.5" name="P66" type="radio" value="0" />
          <label for="P5.3.5">M&aacute;s de 60 min</label><br />&nbsp;&nbsp;

          <p class="label">
            4) ¿Qu&eacute; cigarrillo le es m&aacute;s dif&iacute;cil omitir (dejar de fumar)?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P5.4PM" name="P67" type="radio" value="1" />
          <label for="P5.4PM">El primero de la ma&ntilde;ana</label>
          <input id="P5.4AO" name="P67" type="radio" value="0" checked="checked" />
          <label for="P5.4AO">Alg&uacute;n otro</label><br />&nbsp;&nbsp;

          <p class="label">5) ¿Le es dif&iacute;cil no fumar donde est&aacute; prohibido?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P5.5Si" name="P68" type="radio" value="1" />
          <label for="P5.5Si">SI</label>
          <input id="P5.5No" name="P68" type="radio" value="0" checked="checked" />
          <label for="P5.5No">NO</label><br />&nbsp;&nbsp;

          <p class="label">6) ¿Fuma usted cuando se halla enfermo e incluso en la cama?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P5.6Si" name="P69" type="radio" value="1" />
          <label for="P5.6Si">SI</label>
          <input id="P5.6No" name="P69" type="radio" value="0" checked="checked" />
          <label for="P5.6No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(5)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(7)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 7 -->
      <div class="pagina" id="pagina7" style="display: none">
        <fieldset class="fieldset">
          <legend>Sistema Cardiovascular</legend>

          <label for="P6.1" class="label">Peso:</label>
          <input type="number" step="0.01" id="P6.1" name="P70" class="input" required />
          <br /><br />

          <label for="P6.2" class="label">Talla:</label>
          <input type="number" step="0.01" id="P6.2" name="P71" class="input" required />
          <br /><br />

          <label for="P6.3" class="label">Indice de masa corporal (IMC):</label>
          <input type="number" step="0.01" id="P6.3" name="P72" class="input" required />
          <br /><br />

          <label for="P6.4" class="label">Tensi&oacute;n arterial(TA) 1er. toma:</label>
          <input type="text" id="P6.4" name="P73" class="input" required /> <br /><br />

          <label for="P6.5" class="label">TA 2da. toma:</label>
          <input type="text" id="P6.5" name="P74" class="input" required /><br /><br />

          <label for="P6.6" class="label">TA promedio:</label>
          <input type="text" id="P6.6" name="P75" class="input" required /> <br /><br />

          <label for="P6.7" class="label">Clasificaci&oacute;n:</label>
          <input type="text" id="P6.7" name="P76" class="input" required /> <br /><br />

          <label for="P6.8" class="label">Glicemia Capilar:</label>
          <input type="number" step="0.01" id="P6.8" name="P77" class="input" required />
          <br /><br />

          <label for="P6.9" class="label">Pulso:</label>
          <input type="number" id="P6.9" name="P78" class="input" required /> <br /><br />

          <label for="P6.10" class="label">Saturaci&oacute;n de ox&iacute;geno:</label>
          <input type="number" id="P6.10" name="P79" class="input" required /> <br /><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(6)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(8)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 8 -->
      <div class="pagina" id="pagina8" style="display: none">
        <fieldset class="fieldset">
          <legend>CUESTIONARIO DE FACTORES DE RIESGO</legend>

          <p class="label">1. ¿Alguno de sus hermanos padece o padeci&oacute; diabetes mellitus?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.1Si"
            name="P80"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P7.1Si">SI</label>
          <input id="P7.1No" name="P80" type="radio" value="0" />
          <label for="P7.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">2. ¿Alguno de sus padres padece o padeci&oacute; diabetes mellitus?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.2Si"
            name="P81"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P7.2Si">SI</label>
          <input id="P7.2No" name="P81" type="radio" value="0" />
          <label for="P7.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            3. Mujer. ¿Ha tenido alg&uacute;n bebe con m&aacute;s de 4kg al nacer?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.3Si"
            name="P82"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P7.3Si">SI</label>
          <input id="P7.3No" name="P82" type="radio" value="0" />
          <label for="P7.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            4. ¿Presenta al menos 2 de los siguientes datos? Mucha sed, orina mucho o tiene mucha
            hambre.
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.4Si"
            name="P83"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P7.4Si">SI</label>
          <input id="P7.4No" name="P83" type="radio" value="0" />
          <label for="P7.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">5. Su IMC se ubica en:</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.5normal"
            name="P84"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P7.5normal">normal</label>
          <input id="P7.5sobrepeso" name="P84" type="radio" value="5" />
          <label for="P7.5sobrepeso">sobrepeso</label>
          <input id="P7.5obesidad" name="P84" type="radio" value="10" />
          <label for="P7.5obesidad">obesidad</label><br />&nbsp;&nbsp;

          <p class="label">6. Cintura mujer>=80cm y hombre >=90cm</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.6Si"
            name="P85"
            type="radio"
            value="10"
            checked="checked"
          />
          <label for="P7.6Si">SI</label>
          <input id="P7.6No" name="P85" type="radio" value="0" />
          <label for="P7.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            7. Normalmente hace poco o nada de ejercicio (solo &lt; de 65 a&ntilde;os)
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.7Si"
            name="P86"
            type="radio"
            value="5"
            checked="checked"
          />
          <label for="P7.7Si">SI</label>
          <input id="P7.7No" name="P86" type="radio" value="0" />
          <label for="P7.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">8. Tiene entre 45-64 a&ntilde;os</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.8Si"
            name="P87"
            type="radio"
            value="5"
            checked="checked"
          />
          <label for="P7.8Si">SI</label>
          <input id="P7.8No" name="P87" type="radio" value="0" />
          <label for="P7.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">9. Tiene 65 o m&aacute;s a&ntilde;os de edad.</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P7.9Si"
            name="P88"
            type="radio"
            value="9"
            checked="checked"
          />
          <label for="P7.9Si">SI</label>
          <input id="P7.9No" name="P88" type="radio" value="0" />
          <label for="P7.9No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(7)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(9)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 9 -->
      <div class="pagina" id="pagina9" style="display: none">
        <fieldset class="fieldset">
          <legend>Mantenimiento Del Aporte Suficiente De Alimentos</legend>

          <p class="label">¿En su &aacute;rea de trabajo cuenta con servicio de comedor?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P8.1Si"
            name="P89"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P8.1Si">SI</label>
          <input id="P8.1No" name="P89" type="radio" value="0" />
          <label for="P8.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            ¿Considera que el servicio cuenta con las medidas higi&eacute;nicas necesarias?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P8.2Si"
            name="P90"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P8.2Si">SI</label>
          <input id="P8.2No" name="P90" type="radio" value="0" />
          <label for="P8.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            ¿Considera que el servicio le proporciona una alimentaci&oacute;n saludable y
            balanceada?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P8.3Si"
            name="P91"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P8.3Si">SI</label>
          <input id="P8.3No" name="P91" type="radio" value="0" />
          <label for="P8.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            ¿En su &aacute;rea de trabajo cuenta con alg&uacute;n espacio para degustar sus
            alimentos si es que no usa el servicio de comedor?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P8.4Si"
            name="P92"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P8.4Si">SI</label>
          <input id="P8.4No" name="P92" type="radio" value="0" />
          <label for="P8.4No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(8)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(10)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 10 -->
      <div class="pagina" id="pagina10" style="display: none">
        <fieldset class="fieldset">
          <legend>Actividad y reposo</legend>

          <p class="import">Puede seleccionar m&aacute;s de una opcion si es necesario</p>
          <br />

          <p class="label">1. ¿Realiza esfuerzo f&iacute;sico muy pesado?</p>
          <input type="checkbox" id="P9.1" name="P93" value="1" />
          <label for="P9.1">Miembros superiores</label><br />

          <input type="checkbox" id="P9.1.1" name="P94" value="3" />
          <label for="P9.1.1">Espalda y cintura</label><br />

          <input type="checkbox" id="P9.1.2" name="P95" value="3" />
          <label for="P9.1.2">Piernas (muslos, rodillas, tobillos y pies)</label><br />&nbsp;&nbsp;

          <p class="label">
            Su puesto de trabajo lo obliga a realizar movimientos que requieren fuerza con alguna de
            las siguientes partes del cuerpo
          </p>
          <input type="checkbox" id="P9.2" name="P96" value="2" />
          <label for="P9.2">2. Hombros, brazos o manos</label><br />

          <input type="checkbox" id="P9.3" name="P97" value="2" />
          <label for="P9.3">3. Espalda o cintura</label><br />

          <input type="checkbox" id="P9.4" name="P98" value="2" />
          <label for="P9.4">4. Piernas</label><br />&nbsp;&nbsp;

          <p class="label">Su puesto de trabajo lo obliga a:</p>
          <input type="checkbox" id="P9.5" name="P99" value="1" />
          <label for="P9.5">5. Levantar objetos desde el nivel del piso</label><br />

          <input type="checkbox" id="P9.6" name="P100" value="1" />
          <label for="P9.6"
            >6. Levantar objetos desde alturas que est&aacute;n entre rodillas y pecho</label
          ><br />

          <input type="checkbox" id="P9.7" name="P101" value="3" />
          <label for="P9.7">7. Levantar objetos a alturas por arriba de los hombros</label
          ><br />&nbsp;&nbsp;

          <p class="label">8. Cargar, empujar o jalar objetos hasta de 5 kilos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.8Si"
            name="P102"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P9.8Si">SI</label>
          <input id="P9.8No" name="P102" type="radio" value="0" />
          <label for="P9.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">9. Cargar, empujar o jalar objetos de 6 a 15 kilos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.9Si"
            name="P103"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.9Si">SI</label>
          <input id="P9.9No" name="P103" type="radio" value="0" />
          <label for="P9.9No">NO</label><br />&nbsp;&nbsp;

          <p class="label">10. Cargar, empujar o jalar objetos de 16 a 30 kilos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.10Si"
            name="P104"
            type="radio"
            value="3"
            checked="checked"
          />
          <label for="P9.10Si">SI</label>
          <input id="P9.10No" name="P104" type="radio" value="0" />
          <label for="P9.10No">NO</label><br />&nbsp;&nbsp;

          <p class="label">11. Cargar, empujar o jalar objetos de m&aacute;s 30 kilos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.11Si"
            name="P105"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P9.11Si">SI</label>
          <input id="P9.11No" name="P105" type="radio" value="0" />
          <label for="P9.11No">NO</label><br />&nbsp;&nbsp;

          <p class="label">12. Usar herramientas manuales como martillo, cuchillo o pinza</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.12Si"
            name="P106"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P9.12Si">SI</label>
          <input id="P9.12No" name="P106" type="radio" value="0" />
          <label for="P9.12No">NO</label><br />&nbsp;&nbsp;

          <p class="label">13. Usar herramienta como pico, pala, machete o marro</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.13Si"
            name="P107"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.13Si">SI</label>
          <input id="P9.13No" name="P107" type="radio" value="0" />
          <label for="P9.13No">NO</label><br />&nbsp;&nbsp;

          <p class="label">14. Adoptar posiciones inc&oacute;modas o forzadas</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.14Si"
            name="P108"
            type="radio"
            value="3"
            checked="checked"
          />
          <label for="P9.14Si">SI</label>
          <input id="P9.14No" name="P108" type="radio" value="0" />
          <label for="P9.14No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            15. ¿Realiza movimientos con los brazos por encima o detr&aacute;s de los hombros?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.15Si"
            name="P109"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.15Si">SI</label>
          <input id="P9.15No" name="P109" type="radio" value="0" />
          <label for="P9.15No">NO</label><br />&nbsp;&nbsp;

          <p class="label">16. ¿Para realizar su trabajo usted requiere estar encorvado?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.16Si"
            name="P110"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.16Si">SI</label>
          <input id="P9.16No" name="P110" type="radio" value="0" />
          <label for="P9.16No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            17. ¿El trabajo incluye movimientos repetitivos de las manos o tiene que abrir
            excesivamente los dedos o torcerlos?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.17Si"
            name="P111"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.17Si">SI</label>
          <input id="P9.17No" name="P111" type="radio" value="0" />
          <label for="P9.17No">NO</label><br />&nbsp;&nbsp;

          <p class="label">18. ¿Realiza movimientos de rotaci&oacute;n de la cintura?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.18Si"
            name="P112"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.18Si">SI</label>
          <input id="P9.18No" name="P112" type="radio" value="0" />
          <label for="P9.18No">NO</label><br />&nbsp;&nbsp;

          <p class="label">19. ¿Al realizar su trabajo los hombros est&aacute;n tensos?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.19Si"
            name="P113"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.19Si">SI</label>
          <input id="P9.19No" name="P113" type="radio" value="0" />
          <label for="P9.19No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            20. ¿Tiene que torcer o mantener tensa la o las mu&ntilde;ecas para trabajar?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.20Si"
            name="P114"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.20Si">SI</label>
          <input id="P9.20No" name="P114" type="radio" value="0" />
          <label for="P9.20No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            21. ¿Realiza movimientos repetidos como para mover una manivela para atornillar o
            enroscar?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.21Si"
            name="P115"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.21Si">SI</label>
          <input id="P9.21No" name="P115" type="radio" value="0" />
          <label for="P9.21No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            22. ¿El peso del cuerpo recae solo en uno de los pies o las rodillas (sin posibilidad de
            descansar el pie en un escal&oacute;n o periquera)?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.22Si"
            name="P116"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.22Si">SI</label>
          <input id="P9.22No" name="P116" type="radio" value="0" />
          <label for="P9.22No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            23. ¿Utiliza pedales u otros mecanismos con los pies o las rodillas?<mark
              >(Si la pregunta es NO, pase a la pregunta 26)</mark
            >
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.23Si"
            name="P117"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.23Si">SI</label>
          <input id="P9.23No" name="P117" type="radio" value="0" />
          <label for="P9.23No">NO</label><br />&nbsp;&nbsp;

          <p class="label">24. ¿Utiliza alg&uacute;n asiento sin respaldo o es inc&oacute;modo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P9.24Si" name="P118" type="radio" value="2" />
          <label for="P9.24Si">SI</label>
          <input id="P9.24No" name="P118" type="radio" value="0" checked="checked" />
          <label for="P9.24No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            25. ¿Los dispositivos o pedales son inestables o est&aacute;n mal colocados?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P9.25Si" name="P119" type="radio" value="2" />
          <label for="P9.25Si">SI</label>
          <input id="P9.25No" name="P119" type="radio" value="0" checked="checked" />
          <label for="P9.25No">NO</label><br />&nbsp;&nbsp;

          <p class="label">26. ¿Permanece de pie para trabajar?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.26Si"
            name="P120"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.26Si">SI</label>
          <input id="P9.26No" name="P120" type="radio" value="0" />
          <label for="P9.26No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            27. ¿Para trabajar permanece sentado?
            <mark>(Si la respuesta es NO, pase hasta la pregunta 30)</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.27Si"
            name="P121"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.27Si">SI</label>
          <input id="P9.27No" name="P121" type="radio" value="0" />
          <label for="P9.27No">NO</label><br />&nbsp;&nbsp;

          <p class="label">28. ¿La superficie donde se sienta es inc&oacute;moda?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P9.28Si" name="P122" type="radio" value="2" />
          <label for="P9.28Si">SI</label>
          <input id="P9.28No" name="P122" type="radio" value="0" checked="checked" />
          <label for="P9.28No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            29. ¿Al estar sentado, no es posible apoyar los pies en alg&uacute;n pelda&ntilde;o?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P9.29Si" name="P123" type="radio" value="2" />
          <label for="P9.29Si">SI</label>
          <input id="P9.29No" name="P123" type="radio" value="0" checked="checked" />
          <label for="P9.29No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            30. ¿Para realizar su trabajo debe permanecer en cuclillas o arrodillado?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P9.30Si"
            name="P124"
            type="radio"
            value="2"
            checked="checked"
          />
          <label for="P9.30Si">SI</label>
          <input id="P9.30No" name="P124" type="radio" value="0" />
          <label for="P9.30No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(9)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(11)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 11 -->
      <div class="pagina" id="pagina11" style="display: none">
        <fieldset class="fieldset">
          <legend>Sistema Auditivo y Ocular</legend>

          <p class="import">El trabajador presenta:</p>
          <p class="label">Problemas para Escuchar</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P10Si"
            name="P125"
            type="radio"
            value="SI"
            checked="checked"
          />
          <label for="P10Si">SI</label>
          <input id="P10No" name="P125" type="radio" value="NO" />
          <label for="P10No">NO</label><br />&nbsp;&nbsp;

          <label for="P10.1" class="label">¿Cu&aacute;l?</label>
          <input type="text" id="P10.1" name="P126" class="input" required />

          <p class="label">Problemas para Ver</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P10.2Si"
            name="P127"
            type="radio"
            value="SI"
            checked="checked"
          />
          <label for="P10.2Si">SI</label>
          <input id="P10.2No" name="P127" type="radio" value="NO" />
          <label for="P10.2No">NO</label><br />&nbsp;&nbsp;

          <label for="P10.3" class="label">¿Cu&aacute;l?</label>
          <input type="text" id="P10.3" name="P128" class="input" required />

          <p class="label">
            Su equipo de protecci&oacute;n personal est&aacute; adaptado a sus necesidades auditivas
            o visuales
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P10.4Si"
            name="P129"
            type="radio"
            value="SI"
            checked="checked"
          />
          <label for="P10.4Si">SI</label>
          <input id="P10.4No" name="P129" type="radio" value="NO" />
          <label for="P10.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">¿Necesita apoyo para Escuchar?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P10.5Si"
            name="P130"
            type="radio"
            value="SI"
            checked="checked"
          />
          <label for="P10.5Si">SI</label>
          <input id="P10.5No" name="P130" type="radio" value="NO" />
          <label for="P10.5No">NO</label><br />&nbsp;&nbsp;

          <label for="P10.6" class="label">¿Cu&aacute;l?</label> &nbsp;&nbsp;
          <select id="P10.6" name="P131" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Ninguno">Ninguno</option>
            <option value="Dispositivo Auxiliar">Dispositivo Auxiliar</option></select
          ><br />

          <label for="P10.7" class="label">¿Desde cu&aacute;ndo?</label> &nbsp;&nbsp;
          <select id="P10.7" name="P132" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="De 0 a 1 a&ntilde;o">De 0 a 1 a&ntilde;o</option>
            <option value="De 1 a 5 a&ntilde;os">De 1 a 5 a&ntilde;os</option>
            <option value="De 6 a 10 a&ntilde;os">De 6 a 10 a&ntilde;os</option>
            <option value="M&aacute;s de 10 a&ntilde;os">
              M&aacute;s de 10 a&ntilde;os
            </option></select
          ><br />

          <p class="label">¿Necesita apoyo para ver?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P10.8Si"
            name="P133"
            type="radio"
            value="SI"
            checked="checked"
          />
          <label for="P10.8Si">SI</label>
          <input id="P10.8No" name="P133" type="radio" value="NO" />
          <label for="P10.8No">NO</label><br />&nbsp;&nbsp;

          <label for="P10.9" class="label">¿Cu&aacute;l?</label> &nbsp;&nbsp;
          <select id="P10.9" name="P134" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="Ninguno">Ninguno</option>
            <option value="Uso de lentes">Uso de lentes</option>
            <option value="Uso de lentes de contacto">Uso de lentes de contacto</option></select
          ><br />

          <label for="P10.10" class="label">¿Desde cu&aacute;ndo?</label> &nbsp;&nbsp;
          <select id="P10.10" name="P135" class="select" required>
            <option value="">Seleccione una opci&oacute;n</option>
            <option value="De 0 a 1 a&ntilde;o">De 0 a 1 a&ntilde;o</option>
            <option value="De 1 a 5 a&ntilde;os">De 1 a 5 a&ntilde;os</option>
            <option value="De 6 a 10 a&ntilde;os">De 6 a 10 a&ntilde;os</option>
            <option value="M&aacute;s de 10 a&ntilde;os">
              M&aacute;s de 10 a&ntilde;os
            </option></select
          ><br />
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(10)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(12)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 12 -->
      <div class="pagina" id="pagina12" style="display: none">
        <fieldset class="fieldset">
          <legend>Prevenci&oacute;n de peligros para la vida</legend>

          <p class="import">AUDIT</p>
          <p class="label">
            1. ¿Con qu&eacute; frecuencia consume alguna bebida alcoh&oacute;lica?
            <mark>(Si la respuesta es NUNCA pase a la pregunta 9)</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11N"
            name="P136"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11N">Nunca</label>
          <input id="P11UM" name="P136" type="radio" value="1" />
          <label for="P11UM">Una o menos veces al mes</label>
          <input id="P112a4" name="P136" type="radio" value="2" />
          <label for="P112a4">De 2 a 4 veces al mes</label>
          <input id="P112a3" name="P136" type="radio" value="3" />
          <label for="P112a3">De 2 a 3 veces a la semana</label>
          <input id="P114" name="P136" type="radio" value="4" />
          <label for="P114">4 o m&aacute;s veces a la semana</label><br />&nbsp;&nbsp;

          <p class="label">
            2. ¿Cu&aacute;ntas consumiciones de bebidas alcoh&oacute;licas suele realizar en un
            d&iacute;a de consumo normal?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.1"
            name="P137"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.1">1 o 2</label>
          <input id="P11.2" name="P137" type="radio" value="1" />
          <label for="P11.2">3 o 4</label>
          <input id="P11.3" name="P137" type="radio" value="2" />
          <label for="P11.3">5 o 6</label>
          <input id="P11.4" name="P137" type="radio" value="3" />
          <label for="P11.4">7, 8, o 9</label>
          <input id="P11.5" name="P137" type="radio" value="3" />
          <label for="P11.5">10 o m&aacute;s</label><br />&nbsp;&nbsp;

          <p class="label">
            3. ¿ Con qu&eacute; frecuencia toma 6 o m&aacute;s bebidas alcoh&oacute;licas en un solo
            d&iacute;a?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.6"
            name="P138"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.6">Nunca</label>
          <input id="P11.7" name="P138" type="radio" value="1" />
          <label for="P11.7">Menos de una vez al mes</label>
          <input id="P11.8" name="P138" type="radio" value="2" />
          <label for="P11.8">Mensualmente</label>
          <input id="P11.9" name="P138" type="radio" value="3" />
          <label for="P11.9">Semanalmente</label>
          <input id="P11.10" name="P138" type="radio" value="4" />
          <label for="P11.10">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            4. ¿Con qu&eacute; frecuencia en el curso del &uacute;ltimo a&ntilde;o ha sido incapaz
            de parar de beber una vez hab&iacute;a empezado?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.11"
            name="P139"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.11">Nunca</label>
          <input id="P11.12" name="P139" type="radio" value="1" />
          <label for="P11.12">Menos de una vez al mes</label>
          <input id="P11.13" name="P139" type="radio" value="2" />
          <label for="P11.13">Mensualmente</label>
          <input id="P11.14" name="P139" type="radio" value="3" />
          <label for="P11.14">Semanalmente</label>
          <input id="P11.15" name="P139" type="radio" value="4" />
          <label for="P11.15">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            5. ¿Con qu&eacute; frecuencia en el curso del &uacute;ltimo a&ntilde;o no pudo hacer lo
            que se esperaba de usted porque hab&iacute;a bebido?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.16"
            name="P140"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.16">Nunca</label>
          <input id="P11.17" name="P140" type="radio" value="1" />
          <label for="P11.17">Menos de una vez al mes</label>
          <input id="P11.18" name="P140" type="radio" value="2" />
          <label for="P11.18">Mensualmente</label>
          <input id="P11.19" name="P140" type="radio" value="3" />
          <label for="P11.19">Semanalmente</label>
          <input id="P11.20" name="P140" type="radio" value="4" />
          <label for="P11.20">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            6. ¿Con qu&eacute; frecuencia en el curso del &uacute;ltimo a&ntilde;o ha necesitado
            beber en ayunas para recuperarse despu&eacute;s de haber bebido mucho el d&iacute;a
            anterior?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.21"
            name="P141"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.21">Nunca</label>
          <input id="P11.22" name="P141" type="radio" value="1" />
          <label for="P11.22">Menos de una vez al mes</label>
          <input id="P11.23" name="P141" type="radio" value="2" />
          <label for="P11.23">Mensualmente</label>
          <input id="P11.24" name="P141" type="radio" value="3" />
          <label for="P11.24">Semanalmente</label>
          <input id="P11.25" name="P141" type="radio" value="4" />
          <label for="P11.25">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            7. ¿Con qu&eacute; frecuencia en el curso del &uacute;ltimo a&ntilde;o ha tenido
            remordimientos o sentimientos de culpa despu&eacute;s de haber bebido?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.26"
            name="P142"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.26">Nunca</label>
          <input id="P11.27" name="P142" type="radio" value="1" />
          <label for="P11.27">Menos de una vez al mes</label>
          <input id="P11.28" name="P142" type="radio" value="2" />
          <label for="P11.28">Mensualmente</label>
          <input id="P11.29" name="P142" type="radio" value="3" />
          <label for="P11.29">Semanalmente</label>
          <input id="P11.30" name="P142" type="radio" value="4" />
          <label for="P11.30">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            8. ¿Con qu&eacute; frecuencia en el curso del &uacute;ltimo a&ntilde;o no ha podido
            recordar lo que sucedi&oacute; la noche anterior porque hab&iacute;a estado bebiendo?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.31"
            name="P143"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.31">Nunca</label>
          <input id="P11.32" name="P143" type="radio" value="1" />
          <label for="P11.32">Menos de una vez al mes</label>
          <input id="P11.33" name="P143" type="radio" value="2" />
          <label for="P11.33">Mensualmente</label>
          <input id="P11.34" name="P143" type="radio" value="3" />
          <label for="P11.34">Semanalmente</label>
          <input id="P11.35" name="P143" type="radio" value="4" />
          <label for="P11.35">A diario o casi a diario</label><br />&nbsp;&nbsp;

          <p class="label">
            9. ¿Usted o alguna otra persona ha resultado herido porque usted hab&iacute;a bebido?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.36"
            name="P144"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.36">No</label>
          <input id="P11.37" name="P144" type="radio" value="2" />
          <label for="P11.37">S&iacute;, pero no en el curso del &uacute;ltimo a&ntilde;o</label>
          <input id="P11.38" name="P144" type="radio" value="4" />
          <label for="P11.38">S&iacute;, el &uacute;ltimo a&ntilde;o</label><br />&nbsp;&nbsp;

          <p class="label">
            10. ¿Alg&uacute;n familiar, amigo, m&eacute;dico o profesional sanitario ha mostrado
            preocupaci&oacute;n por su consumo de bebidas alcoh&oacute;licas o le han sugerido que
            deje de beber?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P11.39"
            name="P145"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P11.39">No</label>
          <input id="P11.40" name="P145" type="radio" value="2" />
          <label for="P11.40">S&iacute;, pero no en el curso del &uacute;ltimo a&ntilde;o</label>
          <input id="P11.41" name="P145" type="radio" value="4" />
          <label for="P11.41">S&iacute;, el &uacute;ltimo a&ntilde;o</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(11)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(13)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 13 -->
      <div class="pagina" id="pagina13" style="display: none">
        <fieldset class="fieldset">
          <legend>Factores Ambientales:</legend>

          <p class="import">En su &aacute;rea de trabajo se encuentra expuesto a:</p>
          <p class="label">1. Calor</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.1Si" name="P146" type="radio" value="1" checked="checked" />
          <label for="P12.1Si">SI</label>
          <input id="P12.1No" name="P146" type="radio" value="0" />
          <label for="P12.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">2. Fr&iacute;o</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.2Si" name="P147" type="radio" value="1" checked="checked" />
          <label for="P12.2Si">SI</label>
          <input id="P12.2No" name="P147" type="radio" value="0" />
          <label for="P12.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">3. Cambios bruscos de temperatura</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.3Si" name="P148" type="radio" value="1" checked="checked" />
          <label for="P12.3Si">SI</label>
          <input id="P12.3No" name="P148" type="radio" value="0" />
          <label for="P12.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">4.Falta de ventilaci&oacute;n</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.4Si" name="P149" type="radio" value="1" checked="checked" />
          <label for="P12.4Si">SI</label>
          <input id="P12.4No" name="P149" type="radio" value="0" />
          <label for="P12.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">5. Humedad</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.5Si" name="P150" type="radio" value="1" checked="checked" />
          <label for="P12.5Si">SI</label>
          <input id="P12.5No" name="P150" type="radio" value="0" />
          <label for="P12.5No">NO</label><br />&nbsp;&nbsp;

          <p class="label">6. Poca iluminaci&oacute;n</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.6Si" name="P151" type="radio" value="1" checked="checked" />
          <label for="P12.6Si">SI</label>
          <input id="P12.6No" name="P151" type="radio" value="0" />
          <label for="P12.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">7. Mucha iluminaci&oacute;n</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.7Si" name="P152" type="radio" value="1" checked="checked" />
          <label for="P12.7Si">SI</label>
          <input id="P12.7No" name="P152" type="radio" value="0" />
          <label for="P12.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">8. Ruido</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.8Si" name="P153" type="radio" value="1" checked="checked" />
          <label for="P12.8Si">SI</label>
          <input id="P12.8No" name="P153" type="radio" value="0" />
          <label for="P12.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">9. Vibraciones</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.9Si" name="P154" type="radio" value="1" checked="checked" />
          <label for="P12.9Si">SI</label>
          <input id="P12.9No" name="P154" type="radio" value="0" />
          <label for="P12.9No">NO</label><br />&nbsp;&nbsp;

          <p class="label">10. Radiaciones de soldar</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.10Si" name="P155" type="radio" value="1" checked="checked" />
          <label for="P12.10Si">SI</label>
          <input id="P12.10No" name="P155" type="radio" value="0" />
          <label for="P12.10No">NO</label><br />&nbsp;&nbsp;

          <p class="label">11. Rayos X</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.11Si" name="P156" type="radio" value="1" checked="checked" />
          <label for="P12.11Si">SI</label>
          <input id="P12.11No" name="P156" type="radio" value="0" />
          <label for="P12.11No">NO</label><br /><br />&nbsp;&nbsp;

          <p class="import">
            En su &aacute;rea de trabajo est&aacute; usted constantemente en contacto con:
          </p>

          <p class="label">
            12. Contaminantes biol&oacute;gicos infecciosos (virus, bacterias, hongos)
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.12Si" name="P157" type="radio" value="1" checked="checked" />
          <label for="P12.12Si">SI</label>
          <input id="P12.12No" name="P157" type="radio" value="0" />
          <label for="P12.12No">NO</label><br />&nbsp;&nbsp;

          <p class="label">13. Animales ponzo&ntilde;osos (v&iacute;boras, alacranes, abejas)</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.13Si" name="P158" type="radio" value="1" checked="checked" />
          <label for="P12.13Si">SI</label>
          <input id="P12.13No" name="P158" type="radio" value="0" />
          <label for="P12.13No">NO</label><br />&nbsp;&nbsp;

          <p class="label">14. Palomas u otras aves</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.14Si" name="P159" type="radio" value="1" checked="checked" />
          <label for="P12.14Si">SI</label>
          <input id="P12.14No" name="P159" type="radio" value="0" />
          <label for="P12.14No">NO</label><br />&nbsp;&nbsp;

          <p class="label">15. Polvos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.15Si" name="P160" type="radio" value="1" checked="checked" />
          <label for="P12.15Si">SI</label>
          <input id="P12.15No" name="P160" type="radio" value="0" />
          <label for="P12.15No">NO</label><br />&nbsp;&nbsp;

          <p class="label">16. Humos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <input id="P12.16Si" name="P161" type="radio" value="1" checked="checked" />
          <label for="P12.16Si">SI</label>
          <input id="P12.16No" name="P161" type="radio" value="0" />
          <label for="P12.16No">NO</label><br />&nbsp;&nbsp;

          <p class="label">17. Gases o vapores</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.17Si"
            name="P162"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.17Si">SI</label>
          <input id="P12.17No" name="P162" type="radio" value="0" />
          <label for="P12.17No">NO</label><br />&nbsp;&nbsp;

          <p class="label">18. L&iacute;quidos (disolventes o &aacute;cidos)</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.18Si"
            name="P163"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.18Si">SI</label>
          <input id="P12.18No" name="P163" type="radio" value="0" />
          <label for="P12.18No">NO</label><br />&nbsp;&nbsp;

          <p class="import">En su puesto de trabajo tiene condiciones muy peligrosas debido a:</p>
          <p class="label">19. Los pisos, techos, paredes, rampas o escaleras</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.19Si"
            name="P164"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.19Si">SI</label>
          <input id="P12.19No" name="P164" type="radio" value="0" />
          <label for="P12.19No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            20. La falta de guardas, protecciones o dispositivos, de paro de emergencia en las
            m&aacute;quinas
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.20Si"
            name="P165"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.20Si">SI</label>
          <input id="P12.20No" name="P165" type="radio" value="0" />
          <label for="P12.20No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            21. Las herramientas que utiliza (de mano, el&eacute;ctricas o neum&aacute;ticas)
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.21Si"
            name="P166"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.21Si">SI</label>
          <input id="P12.21No" name="P166" type="radio" value="0" />
          <label for="P12.21No">NO</label><br />&nbsp;&nbsp;

          <p class="label">22. Las instalaciones (el&eacute;ctricas, neum&aacute;ticas o de gas)</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.22Si"
            name="P167"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.22Si">SI</label>
          <input id="P12.22No" name="P167" type="radio" value="0" />
          <label for="P12.22No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            23. La operaci&oacute;n, mantenimiento o limpieza de las m&aacute;quinas o equipos
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.23Si"
            name="P168"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.23Si">SI</label>
          <input id="P12.23No" name="P168" type="radio" value="0" />
          <label for="P12.23No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            24. El manejo, transporte y almacenamiento de materiales y sustancias peligrosas
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.24Si"
            name="P169"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.24Si">SI</label>
          <input id="P12.24No" name="P169" type="radio" value="0" />
          <label for="P12.24No">NO</label><br />&nbsp;&nbsp;

          <p class="label">25. Los equipos de soldadura y corte</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.25Si"
            name="P170"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.25Si">SI</label>
          <input id="P12.25No" name="P170" type="radio" value="0" />
          <label for="P12.25No">NO</label><br />&nbsp;&nbsp;

          <p class="label">26. Las compresoras o calderas en el &aacute;rea de labores</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.26Si"
            name="P171"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.26Si">SI</label>
          <input id="P12.26No" name="P171" type="radio" value="0" />
          <label for="P12.26No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            27. La falta de equipos o personal para la prevenci&oacute;n, protecci&oacute;n o
            combate contra incendios.
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.27Si"
            name="P172"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.27Si">SI</label>
          <input id="P12.27No" name="P172" type="radio" value="0" />
          <label for="P12.27No">NO</label><br />&nbsp;&nbsp;

          <p class="label">28. La falta de orden o limpieza</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.28Si"
            name="P173"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.28Si">SI</label>
          <input id="P12.28No" name="P173" type="radio" value="0" />
          <label for="P12.28No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            29. La falta de equipo de protecci&oacute;n personal o el deficiente mantenimiento.
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.29Si"
            name="P174"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.29Si">SI</label>
          <input id="P12.29No" name="P174" type="radio" value="0" />
          <label for="P12.29No">NO</label><br />&nbsp;&nbsp;

          <p class="import">En su trabajo tiene condiciones insalubres o falta de higiene en:</p>
          <p class="label">
            30. Las instalaciones sanitarias (ba&ntilde;os, regaderas o vestidores)
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.30Si"
            name="P175"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.30Si">SI</label>
          <input id="P12.30No" name="P175" type="radio" value="0" />
          <label for="P12.30No">NO</label><br />&nbsp;&nbsp;

          <p class="label">31. En el comedor y los alimentos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.31Si"
            name="P176"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.31Si">SI</label>
          <input id="P12.31No" name="P176" type="radio" value="0" />
          <label for="P12.31No">NO</label><br />&nbsp;&nbsp;

          <p class="label">32. El agua para beber</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.32Si"
            name="P177"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.32Si">SI</label>
          <input id="P12.32No" name="P177" type="radio" value="0" />
          <label for="P12.32No">NO</label><br />&nbsp;&nbsp;

          <p class="import">Su puesto de trabajo lo obliga a:</p>
          <p class="label">33. Jornada semanal mayor de 48 hrs</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.33Si"
            name="P178"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.33Si">SI</label>
          <input id="P12.33No" name="P178" type="radio" value="0" />
          <label for="P12.33No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            34. Realizar trabajos pendientes en horas o d&iacute;as de descanso o vacaciones
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.34Si"
            name="P179"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.34Si">SI</label>
          <input id="P12.34No" name="P179" type="radio" value="0" />
          <label for="P12.34No">NO</label><br />&nbsp;&nbsp;

          <p class="label">35. Rotaci&oacute;n de turnos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.35Si"
            name="P180"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.35Si">SI</label>
          <input id="P12.35No" name="P180" type="radio" value="0" />
          <label for="P12.35No">NO</label><br />&nbsp;&nbsp;

          <p class="label">36. Trabajo nocturno</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.36Si"
            name="P181"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.36Si">SI</label>
          <input id="P12.36No" name="P181" type="radio" value="0" />
          <label for="P12.36No">NO</label><br />&nbsp;&nbsp;

          <p class="label">37. No poder desatender su tarea por m&aacute;s de 5 minutos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.37Si"
            name="P182"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.37Si">SI</label>
          <input id="P12.37No" name="P182" type="radio" value="0" />
          <label for="P12.37No">NO</label><br />&nbsp;&nbsp;

          <p class="label">38. Mucha concentraci&oacute;n para no accidentarse</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.38Si"
            name="P183"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.38Si">SI</label>
          <input id="P12.38No" name="P183" type="radio" value="0" />
          <label for="P12.38No">NO</label><br />&nbsp;&nbsp;

          <p class="label">39. Realizar una tarea muy minuciosa</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.39Si"
            name="P184"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.39Si">SI</label>
          <input id="P12.39No" name="P184" type="radio" value="0" />
          <label for="P12.39No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            40. Un trabajo repetitivito.<mark>(Si la respuesta es NO pase a la pregunta 43)</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P12.40Si" name="P185" type="radio" value="1" />
          <label for="P12.40Si">SI</label>
          <input id="P12.40No" name="P185" type="radio" value="0" checked="checked" />
          <label for="P12.40No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            41. El conjunto de tareas que realiza se repite por lo menos cada medio minuto
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P12.41Si" name="P186" type="radio" value="1" />
          <label for="P12.41Si">SI</label>
          <input id="P12.41No" name="P186" type="radio" value="0" checked="checked" />
          <label for="P12.41No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            42. El conjunto de tareas que realiza se repite por lo menos entre medio minuto y 5
            minutos
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.42Si"
            name="P187"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.42Si">SI</label>
          <input id="P12.42No" name="P187" type="radio" value="0" checked="checked" />
          <label for="P12.42No">NO</label><br />&nbsp;&nbsp;

          <p class="label">43. Cubrir una cuota de producci&oacute;n</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.43Si"
            name="P188"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.43Si">SI</label>
          <input id="P12.43No" name="P188" type="radio" value="0" />
          <label for="P12.43No">NO</label><br />&nbsp;&nbsp;

          <p class="label">44. Realizar un trabajo a destajo</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.44Si"
            name="P189"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.44Si">SI</label>
          <input id="P12.44No" name="P189" type="radio" value="0" />
          <label for="P12.44No">NO</label><br />&nbsp;&nbsp;

          <p class="label">45. Soportar una supervisi&oacute;n estricta</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.45Si"
            name="P190"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.45Si">SI</label>
          <input id="P12.45No" name="P190" type="radio" value="0" />
          <label for="P12.45No">NO</label><br />&nbsp;&nbsp;

          <p class="label">46. Un estricto control de calidad</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.46Si"
            name="P191"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.46Si">SI</label>
          <input id="P12.46No" name="P191" type="radio" value="0" />
          <label for="P12.46No">NO</label><br />&nbsp;&nbsp;

          <p class="label">47. Estar sin comunicaci&oacute;n con sus compa&ntilde;eros</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.47Si"
            name="P192"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.47Si">SI</label>
          <input id="P12.47No" name="P192" type="radio" value="0" />
          <label for="P12.47No">NO</label><br />&nbsp;&nbsp;

          <p class="label">48. Trabajar en un espacio reducido</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.48Si"
            name="P193"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.48Si">SI</label>
          <input id="P12.48No" name="P193" type="radio" value="0" />
          <label for="P12.48No">NO</label><br />&nbsp;&nbsp;

          <p class="label">49. Estar fijo en su lugar de trabajo</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.49Si"
            name="P194"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.49Si">SI</label>
          <input id="P12.49No" name="P194" type="radio" value="0" />
          <label for="P12.49No">NO</label><br />&nbsp;&nbsp;

          <p class="label">50. Realizar un trabajo aburrido</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.50Si"
            name="P195"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.50Si">SI</label>
          <input id="P12.50No" name="P195" type="radio" value="0" />
          <label for="P12.50No">NO</label><br />&nbsp;&nbsp;

          <p class="label">51. Ejecutar un trabajo peligroso</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.51Si"
            name="P196"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.51Si">SI</label>
          <input id="P12.51No" name="P196" type="radio" value="0" />
          <label for="P12.51No">NO</label><br />&nbsp;&nbsp;

          <p class="label">52. Ejecutar un trabajo denigrante</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.52Si"
            name="P197"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.52Si">SI</label>
          <input id="P12.52No" name="P197" type="radio" value="0" />
          <label for="P12.52No">NO</label><br />&nbsp;&nbsp;

          <p class="label">53. Recibir &oacute;rdenes confusas o muy poco claras de su jefe</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.53Si"
            name="P198"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.53Si">SI</label>
          <input id="P12.53No" name="P198" type="radio" value="0" />
          <label for="P12.53No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            54. Realizar alg&uacute;n trabajo que le puede ocasionar da&ntilde;o a su salud
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.54Si"
            name="P199"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.54Si">SI</label>
          <input id="P12.54No" name="P199" type="radio" value="0" />
          <label for="P12.54No">NO</label><br />&nbsp;&nbsp;

          <p class="label">55. Realizar esfuerzo f&iacute;sico muy pesado</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.55Si"
            name="P200"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.55Si">SI</label>
          <input id="P12.55No" name="P200" type="radio" value="0" />
          <label for="P12.55No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            1. En su &aacute;rea de trabajo existe alg&uacute;n m&eacute;todo o sistema para recibir
            atenci&oacute;n m&eacute;dica o primeros auxilios en caso de ser necesario
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.01Si"
            name="P201"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.01Si">SI</label>
          <input id="P12.01No" name="P201" type="radio" value="0" />
          <label for="P12.01No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            2. Conoce alg&uacute;n programa de salud que se aplique en su empresa.
            <mark>(Si la respuesta es NO, pase al siguiente apartado)</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P12.02Si"
            name="P202"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P12.02Si">SI</label>
          <input id="P12.02No" name="P202" type="radio" value="0" />
          <label for="P12.02No">NO</label><br />&nbsp;&nbsp;

          <p class="label">3. Participa en alguno de ellos</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P12.03Si" name="P203" type="radio" value="1" />
          <label for="P12.03Si">SI</label>
          <input id="P12.03No" name="P203" type="radio" value="0" checked="checked" />
          <label for="P12.03No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(12)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(14)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 14 -->
      <div class="pagina" id="pagina14" style="display: none">
        <fieldset class="fieldset">
          <legend>Promoci&oacute;n del funcionamiento Humano</legend>

          <p class="import">ESCALA DE ESTR&Eacute;S PERCIBIDO</p>
          <p class="label">
            1.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha estado afectado por algo que
            ocurri&oacute; inesperadamente?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.1N"
            name="P204"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.1N">NUNCA</label>
          <input id="P13.1CN" name="P204" type="radio" value="1" />
          <label for="P13.1CN">CASI NUNCA</label>
          <input id="P13.1VC" name="P204" type="radio" value="2" />
          <label for="P13.1VC">DE VEZ EN CUANDO</label>
          <input id="P13.1AM" name="P204" type="radio" value="3" />
          <label for="P13.1AM">A MENUDO</label>
          <input id="P13.1MA" name="P204" type="radio" value="4" />
          <label for="P13.1MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            2.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia se ha sentido incapaz de
            controlar las cosas de su vida?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.2N"
            name="P205"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.2N">NUNCA</label>
          <input id="P13.2CN" name="P205" type="radio" value="1" />
          <label for="P13.2CN">CASI NUNCA</label>
          <input id="P13.2VC" name="P205" type="radio" value="2" />
          <label for="P13.2VC">DE VEZ EN CUANDO</label>
          <input id="P13.2AM" name="P205" type="radio" value="3" />
          <label for="P13.2AM">A MENUDO</label>
          <input id="P13.2MA" name="P205" type="radio" value="4" />
          <label for="P13.2MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            3.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia se ha sentido nervioso o
            estresado?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.3N"
            name="P206"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.3N">NUNCA</label>
          <input id="P13.3CN" name="P206" type="radio" value="1" />
          <label for="P13.3CN">CASI NUNCA</label>
          <input id="P13.3VC" name="P206" type="radio" value="2" />
          <label for="P13.3VC">DE VEZ EN CUANDO</label>
          <input id="P13.3AM" name="P206" type="radio" value="3" />
          <label for="P13.3AM">A MENUDO</label>
          <input id="P13.3MA" name="P206" type="radio" value="4" />
          <label for="P13.3MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            4.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha manejado con &eacute;xito los
            peque&ntilde;os problemas irritantes de la vida?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.4N"
            name="P207"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.4N">NUNCA</label>
          <input id="P13.4CN" name="P207" type="radio" value="3" />
          <label for="P13.4CN">CASI NUNCA</label>
          <input id="P13.4VC" name="P207" type="radio" value="2" />
          <label for="P13.4VC">DE VEZ EN CUANDO</label>
          <input id="P13.4AM" name="P207" type="radio" value="1" />
          <label for="P13.4AM">A MENUDO</label>
          <input id="P13.4MA" name="P207" type="radio" value="0" />
          <label for="P13.4MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            5.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha sentido que ha afrontado los
            cambios importantes que han estado ocurriendo en su vida?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.5N"
            name="P208"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.5N">NUNCA</label>
          <input id="P13.5CN" name="P208" type="radio" value="3" />
          <label for="P13.5CN">CASI NUNCA</label>
          <input id="P13.5VC" name="P208" type="radio" value="2" />
          <label for="P13.5VC">DE VEZ EN CUANDO</label>
          <input id="P13.5AM" name="P208" type="radio" value="1" />
          <label for="P13.5AM">A MENUDO</label>
          <input id="P13.5MA" name="P208" type="radio" value="0" />
          <label for="P13.5MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            6.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha estado seguro sobre su
            capacidad para manejar sus problemas personales?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.6N"
            name="P209"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.6N">NUNCA</label>
          <input id="P13.6CN" name="P209" type="radio" value="3" />
          <label for="P13.6CN">CASI NUNCA</label>
          <input id="P13.6VC" name="P209" type="radio" value="2" />
          <label for="P13.6VC">DE VEZ EN CUANDO</label>
          <input id="P13.6AM" name="P209" type="radio" value="1" />
          <label for="P13.6AM">A MENUDO</label>
          <input id="P13.6MA" name="P209" type="radio" value="0" />
          <label for="P13.6MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            7.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha sentido que las cosas van
            bien?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.7N"
            name="P210"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.7N">NUNCA</label>
          <input id="P13.7CN" name="P210" type="radio" value="3" />
          <label for="P13.7CN">CASI NUNCA</label>
          <input id="P13.7VC" name="P210" type="radio" value="2" />
          <label for="P13.7VC">DE VEZ EN CUANDO</label>
          <input id="P13.7AM" name="P210" type="radio" value="1" />
          <label for="P13.7AM">A MENUDO</label>
          <input id="P13.7MA" name="P210" type="radio" value="0" />
          <label for="P13.7MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            8.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha sentido que no ha podido
            afrontar todas las cosas que ten&iacute;a que hacer?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.8N"
            name="P211"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.8N">NUNCA</label>
          <input id="P13.8CN" name="P211" type="radio" value="1" />
          <label for="P13.8CN">CASI NUNCA</label>
          <input id="P13.8VC" name="P211" type="radio" value="2" />
          <label for="P13.8VC">DE VEZ EN CUANDO</label>
          <input id="P13.8AM" name="P211" type="radio" value="3" />
          <label for="P13.8AM">A MENUDO</label>
          <input id="P13.8MA" name="P211" type="radio" value="4" />
          <label for="P13.8MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            9.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha podido controlar las
            dificultades de su vida?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.9N"
            name="P212"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.9N">NUNCA</label>
          <input id="P13.9CN" name="P212" type="radio" value="3" />
          <label for="P13.9CN">CASI NUNCA</label>
          <input id="P13.9VC" name="P212" type="radio" value="2" />
          <label for="P13.9VC">DE VEZ EN CUANDO</label>
          <input id="P13.9AM" name="P212" type="radio" value="1" />
          <label for="P13.9AM">A MENUDO</label>
          <input id="P13.9MA" name="P212" type="radio" value="0" />
          <label for="P13.9MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            10.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia siente que tiene el control de
            todo?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.10N"
            name="P213"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.10N">NUNCA</label>
          <input id="P13.10CN" name="P213" type="radio" value="1" />
          <label for="P13.10CN">CASI NUNCA</label>
          <input id="P13.10VC" name="P213" type="radio" value="2" />
          <label for="P13.10VC">DE VEZ EN CUANDO</label>
          <input id="P13.10AM" name="P213" type="radio" value="3" />
          <label for="P13.10AM">A MENUDO</label>
          <input id="P13.10MA" name="P213" type="radio" value="4" />
          <label for="P13.10MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            11.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha estado enfadado porque las
            cosas que le han ocurrido estaban fuera de su control?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.11N"
            name="P214"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.11N">NUNCA</label>
          <input id="P13.11CN" name="P214" type="radio" value="1" />
          <label for="P13.11CN">CASI NUNCA</label>
          <input id="P13.11VC" name="P214" type="radio" value="2" />
          <label for="P13.11VC">DE VEZ EN CUANDO</label>
          <input id="P13.11AM" name="P214" type="radio" value="3" />
          <label for="P13.11AM">A MENUDO</label>
          <input id="P13.11MA" name="P214" type="radio" value="4" />
          <label for="P13.11MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            12.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha pensado en las cosas que le
            quedan por lograr?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.12N"
            name="P215"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.12N">NUNCA</label>
          <input id="P13.12CN" name="P215" type="radio" value="1" />
          <label for="P13.12CN">CASI NUNCA</label>
          <input id="P13.12VC" name="P215" type="radio" value="2" />
          <label for="P13.12VC">DE VEZ EN CUANDO</label>
          <input id="P13.12AM" name="P215" type="radio" value="3" />
          <label for="P13.12AM">A MENUDO</label>
          <input id="P13.12MA" name="P215" type="radio" value="4" />
          <label for="P13.12MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            13.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha podido controlar el tiempo?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.13N"
            name="P216"
            type="radio"
            value="4"
            checked="checked"
          />
          <label for="P13.13N">NUNCA</label>
          <input id="P13.13CN" name="P216" type="radio" value="3" />
          <label for="P13.13CN">CASI NUNCA</label>
          <input id="P13.13VC" name="P216" type="radio" value="2" />
          <label for="P13.13VC">DE VEZ EN CUANDO</label>
          <input id="P13.13AM" name="P216" type="radio" value="1" />
          <label for="P13.13AM">A MENUDO</label>
          <input id="P13.13MA" name="P216" type="radio" value="0" />
          <label for="P13.13MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="label">
            14.- En el &uacute;ltimo mes ¿Con qu&eacute; frecuencia ha sentido que las dificultades
            se acumulan tanto que no puede superarlas?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P13.14N"
            name="P217"
            type="radio"
            value="0"
            checked="checked"
          />
          <label for="P13.14N">NUNCA</label>
          <input id="P13.14CN" name="P217" type="radio" value="1" />
          <label for="P13.14CN">CASI NUNCA</label>
          <input id="P13.14VC" name="P217" type="radio" value="2" />
          <label for="P13.14VC">DE VEZ EN CUANDO</label>
          <input id="P13.14AM" name="P217" type="radio" value="3" />
          <label for="P13.14AM">A MENUDO</label>
          <input id="P13.14MA" name="P217" type="radio" value="4" />
          <label for="P13.14MA">MUY AMENUDO</label><br />&nbsp;&nbsp;

          <p class="import">ESCALA DE ANSIEDAD DE GOLDBERG</p>
          <p class="label">1. ¿Se ha sentido muy excitado, nervioso o en tensi&oacute;n?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P14.1Si"
            name="P218"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P14.1Si">SI</label>
          <input id="P14.1No" name="P218" type="radio" value="0" />
          <label for="P14.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">2. ¿Ha estado muy preocupado por algo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P14.2Si"
            name="P219"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P14.2Si">SI</label>
          <input id="P14.2No" name="P219" type="radio" value="0" />
          <label for="P14.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">3. ¿Se ha sentido muy irritable?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P14.3Si"
            name="P220"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P14.3Si">SI</label>
          <input id="P14.3No" name="P220" type="radio" value="0" />
          <label for="P14.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            4. ¿Ha tenido dificultad para relajarse?
            <mark>(Si hay 2 o m&aacute;s respuestas afirmativas, continuar preguntando)</mark>
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input
            id="P14.4Si"
            name="P221"
            type="radio"
            value="1"
            checked="checked"
          />
          <label for="P14.4Si">SI</label>
          <input id="P14.4No" name="P221" type="radio" value="0" />
          <label for="P14.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">5. ¿Ha dormido mal, ha tenido dificultades para dormir?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P14.5Si" name="P222" type="radio" value="1" />
          <label for="P14.5Si">SI</label>
          <input id="P14.5No" name="P222" type="radio" value="0" checked="checked" />
          <label for="P14.5No">NO</label><br />&nbsp;&nbsp;

          <p class="label">6. ¿Ha tenido dolores de cabeza o nuca?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P14.6Si" name="P223" type="radio" value="1" />
          <label for="P14.6Si">SI</label>
          <input id="P14.6No" name="P223" type="radio" value="0" checked="checked" />
          <label for="P14.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            7. ¿Ha tenido alguno de los siguientes s&iacute;ntomas: temblores, hormigueos, mareos,
            sudores, diarrea? (s&iacute;ntomas vegetativos)
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P14.7Si" name="P224" type="radio" value="1" />
          <label for="P14.7Si">SI</label>
          <input id="P14.7No" name="P224" type="radio" value="0" checked="checked" />
          <label for="P14.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">8. ¿Ha estado preocupado por su salud?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P14.8Si" name="P225" type="radio" value="1" />
          <label for="P14.8Si">SI</label>
          <input id="P14.8No" name="P225" type="radio" value="0" checked="checked" />
          <label for="P14.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            9. ¿Ha tenido alguna dificultad para conciliar el sue&ntilde;o, para quedarse dormido?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P14.9Si" name="P226" type="radio" value="1" />
          <label for="P14.9Si">SI</label>
          <input id="P14.9No" name="P226" type="radio" value="0" checked="checked" />
          <label for="P14.9No">NO</label><br />&nbsp;&nbsp;

          <p class="import">ESCALA DE DEPRESI&Oacute;N DE GOLDBERG</p>

          <p class="label">1. ¿Se ha sentido con poca energ&iacute;a?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.1Si" name="P227" type="radio" value="1" />
          <label for="P15.1Si">SI</label>
          <input id="P15.1No" name="P227" type="radio" value="0" checked="checked" />
          <label for="P15.1No">NO</label><br />&nbsp;&nbsp;

          <p class="label">2. ¿Ha perdido usted su inter&eacute;s por las cosas?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.2Si" name="P228" type="radio" value="1" />
          <label for="P15.2Si">SI</label>
          <input id="P15.2No" name="P228" type="radio" value="0" checked="checked" />
          <label for="P15.2No">NO</label><br />&nbsp;&nbsp;

          <p class="label">3. ¿Ha perdido la confianza en s&iacute; mismo?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.3Si" name="P229" type="radio" value="1" />
          <label for="P15.3Si">SI</label>
          <input id="P15.3No" name="P229" type="radio" value="0" checked="checked" />
          <label for="P15.3No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            4. ¿Se ha sentido usted desesperanzado, sin esperanzas?
            <mark
              >(Si hay respuestas afirmativas a cualquiera de las preguntas anteriores,
              continuar)</mark
            >
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.4Si" name="P230" type="radio" value="1" />
          <label for="P15.4Si">SI</label>
          <input id="P15.4No" name="P230" type="radio" value="0" checked="checked" />
          <label for="P15.4No">NO</label><br />&nbsp;&nbsp;

          <p class="label">5. ¿Ha tenido dificultades para concentrarse?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.5Si" name="P231" type="radio" value="1" />
          <label for="P15.5Si">SI</label>
          <input id="P15.5No" name="P231" type="radio" value="0" checked="checked" />
          <label for="P15.5No">NO</label><br />&nbsp;&nbsp;

          <p class="label">6. ¿Ha perdido peso? (a causa de su falta de apetito)</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.6Si" name="P232" type="radio" value="1" />
          <label for="P15.6Si">SI</label>
          <input id="P15.6No" name="P232" type="radio" value="0" checked="checked" />
          <label for="P15.6No">NO</label><br />&nbsp;&nbsp;

          <p class="label">7. ¿Se ha estado despertando demasiado temprano?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.7Si" name="P233" type="radio" value="1" />
          <label for="P15.7Si">SI</label>
          <input id="P15.7No" name="P233" type="radio" value="0" checked="checked" />
          <label for="P15.7No">NO</label><br />&nbsp;&nbsp;

          <p class="label">8. ¿Se ha sentido usted enlentecido?</p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.8Si" name="P234" type="radio" value="1" />
          <label for="P15.8Si">SI</label>
          <input id="P15.8No" name="P234" type="radio" value="0" checked="checked" />
          <label for="P15.8No">NO</label><br />&nbsp;&nbsp;

          <p class="label">
            9. ¿Cree usted que ha tenido tendencia a encontrarse peor por las ma&ntilde;anas?
          </p>
          &nbsp;&nbsp;&nbsp;&nbsp;<input id="P15.9Si" name="P235" type="radio" value="1" />
          <label for="P15.9Si">SI</label>
          <input id="P15.9No" name="P235" type="radio" value="0" checked="checked" />
          <label for="P15.9No">NO</label><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton flecha" onclick="mostrarPagina(13)">&#x25C0;</button>
          <button type="button" class="boton flecha" onclick="mostrarPagina(15)">&#x25B6;</button>
        </div>
      </div>

      <!-- Página 15 -->
      <div class="pagina" id="pagina15" style="display: none">
        <fieldset class="fieldset">
          <legend>ANEXO 1</legend>

          <label for="P16" class="label">OBSERVACIONES:</label>
          <input type="text" id="P16" name="observacion" class="input" required /><br />&nbsp;&nbsp;

          <label for="P17" class="label"
            >DIAGN&Oacute;STICOS M&Eacute;DICOS Y MEDICAMENTOS DEL PACIENTE :</label
          >
          <input type="text" id="P17" name="diagnostico" class="input" required /><br />&nbsp;&nbsp;
        </fieldset>
        <div class="navegacion">
          <button type="button" class="boton-completo" onclick="mostrarPagina(14)">
            <span class="flecha">&#x25C0;</span> Anterior
          </button>
        </div>
      </div>

      <!-- Índice de navegación -->
      <div class="navegacion">
        <span onclick="mostrarPagina(1)">1</span>
        <span onclick="mostrarPagina(2)">2</span>
        <span onclick="mostrarPagina(3)">3</span>
        <span onclick="mostrarPagina(4)">4</span>
        <span onclick="mostrarPagina(5)">5</span>
        <span onclick="mostrarPagina(6)">6</span>
        <span onclick="mostrarPagina(7)">7</span>
        <span onclick="mostrarPagina(8)">8</span>
        <span onclick="mostrarPagina(9)">9</span>
        <span onclick="mostrarPagina(10)">10</span>
        <span onclick="mostrarPagina(11)">11</span>
        <span onclick="mostrarPagina(12)">12</span>
        <span onclick="mostrarPagina(13)">13</span>
        <span onclick="mostrarPagina(14)">14</span>
        <span onclick="mostrarPagina(15)">15</span>
      </div>
      <button type="submit" class="boton" onclick="confirmarForm();">Enviar Formulario</button>
    </form>
    <br />
  </div>
</template>

<script>
function mostrarPagina(n) {
  const paginas = document.querySelectorAll('.pagina')
  paginas.forEach((p) => (p.style.display = 'none'))
  document.getElementById('pagina' + n).style.display = 'block'
}
</script>
