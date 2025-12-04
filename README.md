# 🧙‍♀️ BRUJAS DEFIENDEN LA ACADEMIA  
### *Juego estilo "Plants vs Zombies" desarrollado en Windows Forms*

<p align="center">
  <img src="https://img.shields.io/badge/Lenguaje-C%23-239120?logo=csharp" />
  <img src="https://img.shields.io/badge/Framework-.NET%20Windows%20Forms-512BD4?logo=dotnet" />
  <img src="https://img.shields.io/badge/Estado-Completo-brightgreen" />
  <img src="https://img.shields.io/badge/Plataforma-Windows-lightgrey?logo=windows" />
</p>

---

## 👩‍💻 Desarrolladora  
**[Beatriz Aller](https://github.com/allerglezz)**

---

## 🎯 Objetivo del juego  
Defiende la academia colocando **defensoras mágicas** en distintas casillas del tablero.

- 🏆 **Ganas** si eliminas a todos los enemigos de la oleada.  
- ❌ **Pierdes** si un solo enemigo alcanza la **primera columna (la más a la izquierda)**.

---

## 🕹️ Instrucciones de juego

- Comienzas con **10 de maná**.
- Cada defensora cuesta una cantidad distinta.
- Selecciona **fila y columna**, luego pulsa el botón de la defensora para colocarla.
- No puedes colocar en una casilla ya ocupada.
- Los enemigos aparecen en **filas aleatorias** y avanzan hacia la izquierda.
- Planifica tus recursos y **coloca estratégicamente** para sobrevivir a la oleada.

---

# 🔮 Defensoras disponibles

---

## 🧙‍♂️ **Mago**
- **Coste:** 5 maná  
- **Función:** Dispara proyectiles mágicos hacia la derecha.  
- **Daño:** 1 (elimina al enemigo instantáneamente).  
- **Equivalente PvZ:** Lanzaguisantes (versión daño alto).  

---

## 👑 **Emperatriz**
- **Coste:** 3 maná  
- **Función:** Lanza invocaciones periódicas que avanzan solas.  
- **Daño:** 1 por invocación (dos impactos para eliminar un enemigo).  
- **Notas:** Las invocaciones desaparecen al impactar y **no atraviesan enemigos**.  
- **Equivalente PvZ:** Lanzaguisantes clásico (con comportamiento diferente).  

---

## 🧱 **Torre**
- **Coste:** 2 maná  
- **Función:** Actúa como muro protector.  
- **Vida:** 3 puntos.  
- **Equivalente PvZ:** Nuez.  

---

## 💀 **Muerte**
- **Coste:** 4 maná  
- **Función:** Mina que elimina inmediatamente al enemigo que pise su casilla.  
- **Comportamiento:** No tiene retraso, mata al instante.  
- **Equivalente PvZ:** Papapum (pero instantáneo).  

---

## 🌙 **Luna**
- **Coste:** 2 maná  
- **Función:** Aumenta la **regeneración de maná** del jugador.  
- **Estrategia:** Colócala temprano para maximizar recursos.  
- **Equivalente PvZ:** Girasol.  

---

# 🧟‍♂️ Enemigos

- Todos los enemigos tienen **2 puntos de vida**.  
- Pueden morir:
  - de **un impacto** (Mago o Muerte),  
  - o de **dos impactos** (Emperatriz).  
- Si un enemigo alcanza la **columna 0**, la partida termina con derrota.  
- Si eliminas a toda la oleada, aparece un mensaje de victoria.

---

# 📝 Notas adicionales

- No se pueden colocar defensoras sin suficiente maná.  
- El juego muestra un mensaje al ganar o perder.  
- Los timers se detienen al finalizar la partida.  
- El comportamiento de proyectiles, invocaciones y colisiones está gestionado mediante eventos en Windows Forms.

---

# ⚙️ Información técnica
Para claridad del repositorio:

- El proyecto está desarrollado en **C# con Windows Forms**, usando timers para:  
  - movimiento de enemigos  
  - movimiento de proyectiles  
  - invocaciones de la Emperatriz  
- El tablero se gestiona mediante **arrays bidimensionales**, donde cada casilla almacena:
  - tipo de defensora  
  - vida restante (si aplica)  
  - presencia de enemigo  
- La lógica de victoria/derrota se ejecuta cada vez que:
  - un enemigo avanza,
  - un enemigo recibe daño,
  - o se genera una nueva invocación/proyectil.

---

# 📦 Instalación y ejecución
1. Clonar o descargar el repositorio.  
2. Abrir la solución en **Visual Studio**.  
3. Compilar y ejecutar.

---

# 📜 Licencia
Este proyecto se distribuye bajo la **MIT License**.  
Puedes usarlo, modificarlo o distribuirlo libremente siempre que mantengas el aviso de copyright.
