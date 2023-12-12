


// boxes with text
function show1() {

    document.getElementById('header1').innerHTML = /*HTML*/`
     <div class="innerCard">
            De to viktigste verktøyene vi skal bruke er disse:
            <ul>
                <li>
                    Koderedigeringsprogrammet <a href="https://code.visualstudio.com/">Visual Studio Code</a>
                    <br>Vi skal bruke noen <i>extensions</i>:
                    <ul>
                        <li>JavaScript-booster</li>
                        <li>es6-string-html</li>
                        <li>live-server</li>
                        <li>live-share</li>
                    </ul>
                </li>
                <li>Nettleseren <a href="https://www.google.com/intl/no/chrome/">Google Chrome</a></li>
            </ul>
        </div>`
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
    document.getElementById('header6').innerHTML = ''
        ;
}
function show2() {
    document.getElementById('header2').innerHTML = /*HTML*/`
        <div class="innerCard">
            Vi bruker HTML til å definere et dokument.
            <ul>
                <li>Tagger for grunnleggende oppsett av en HTML-fil</li>
                <li>Tagger for grunnleggende formatering av tekst</li>
                <li><tt>&lt;div&gt;</tt></li>
                <li><tt>&lt;input type="text"&gt;</tt></li>
                <li><tt>&lt;button&gt;</tt></li>
                <li><a href="https://www.w3schools.com/html/default.asp" target="_new">W3Schools HTML Tutorial</a>
                </li>
                <li><a href="https://www.w3schools.com/tags/default.asp" target="_new">W3Schools HTML Reference</a>
                </li>
            </ul>
        </div>
    `
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
        ;
}
function show3() {
    document.getElementById('header3').innerHTML = /*HTML*/`
 <div class="innerCard">
            Vi bruker CSS til å <i>style</i> et dokument, altså farger, fonter, utseende og lignende.
            <ul>
                <li><tt>background-color</tt></li>
                <li><tt>color</tt></li>
                <li><tt>padding</tt></li>
                <li><tt>margin</tt></li>
                <li><tt>border</tt></li>
                <li><tt>text-align</tt></li>
                <li><tt>font-size</tt></li>
                <li><a href="https://css-tricks.com/snippets/css/a-guide-to-flexbox/" target="_new">Flexbox</a></li>
                <li><a href="https://css-tricks.com/snippets/css/complete-guide-grid/" target="_new">Grid</a></li>
                <li><a href="https://www.w3schools.com/css/default.asp" target="_new">W3Schools CSS Tutorial</a>
                </li>
                <li><a href="https://www.w3schools.com/cssref/default.asp" target="_new">W3Schools CSS Reference</a>
                </li>
            </ul>
            
        </div>
    `
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
    document.getElementById('header6').innerHTML = ''
        ;
}
function show4() {
    document.getElementById('header4').innerHTML = /*HTML*/`
        <div class="innerCard">
            Det viktigste vi skal lære er programmeringsspråket JavaScript. Vi skal lære grunnleggende programmering
            ved
            å manipulere HTML- og CSS-kode på en nettside ved hjelp av JavaScript.
            <ul>
                <li><tt>background-color</tt></li>
                <li><tt>color</tt></li>
                <li><tt>padding</tt></li>
                <li><tt>margin</tt></li>
                <li><tt>border</tt></li>
                <li><tt>text-align</tt></li>
                <li><tt>font-size</tt></li>
                <li>Det finnes en W3Schools JavaScript Tutorial, men her anbefaler vi heller å følge kurset vårt på
                    Moodle.</li>
                <li><a href="https://www.w3schools.com/jsref/default.asp" target="_new">W3Schools JavaScript
                        Reference</a></li>
            </ul>
        </div>

    `
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
    document.getElementById('header6').innerHTML = ''
        ;
}

//select bodyparts "game"
function show5() {

    document.getElementById('header5').innerHTML = /*HTML*/`
    <div class="cardgame">

        <div class="bodyparts" id=head>
            <button onclick="head4()">◀</button>
                <div>
                    <img src="IMG/head1.png" alt="">
                </div>
            <button onclick="head2()">▶</button>
        </div>

        <div class="bodyparts" id=body>
             <button onclick="body4()">◀</button>
                <div>
                    <img src="IMG/body1.png" alt="">
                </div>
             <button onclick="body2()">▶</button>
        </div>

        <div class="bodyparts" id=leg>
            <button onclick="leg4()">◀</button>
                <div>
                    <img src="IMG/legs1.png" alt="">
                </div>
            <button onclick="leg2()">▶</button>
     </div>

     `
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header6').innerHTML = ''
        ;
}
function head1() {
    document.getElementById('head').innerHTML = /*HTML*/ `
        <button onclick="head4()">◀</button>
            <div>
                <img src="IMG/head1.png" alt="">
            </div>
        <button onclick="head2()">▶</button>
    `;
}
function head2() {
    document.getElementById('head').innerHTML = /*HTML*/ `
        <button onclick="head1()">◀</button>
            <div>
                <img src="IMG/head2.png" alt="">
            </div>
        <button onclick="head3()">▶</button>
    `;
}
function head3() {
    document.getElementById('head').innerHTML = /*HTML*/ `
        <button onclick="head2()">◀</button>
            <div>
                <img src="IMG/head3.png" alt="">
            </div>
        <button onclick="head4()">▶</button>
    `;
}
function head4() {
    document.getElementById('head').innerHTML = /*HTML*/ `
        <button onclick="head3()">◀</button>
            <div>
                <img src="IMG/head4.png" alt="">
            </div>
        <button onclick="head1()">▶</button>
 `;
}
function body1() {
    document.getElementById('body').innerHTML = /*HTML*/ `
        <button onclick="body4()">◀</button>
            <div>
                <img src="IMG/body1.png" alt="">
            </div>
        <button onclick="body2()">▶</button>
 `;
}
function body2() {
    document.getElementById('body').innerHTML = /*HTML*/ `
        <button onclick="body1()">◀</button>
            <div>
                <img src="IMG/body2.png" alt="">
            </div>
        <button onclick="body3()">▶</button>
 `;
}
function body3() {
    document.getElementById('body').innerHTML = /*HTML*/ `
        <button onclick="body2()">◀</button>
            <div>
                <img src="IMG/body3.png" alt="">
            </div>
        <button onclick="body4()">▶</button>
 `;
}
function body4() {
    document.getElementById('body').innerHTML = /*HTML*/ `
        <button onclick="body3()">◀</button>
            <div>
                <img src="IMG/body4.png" alt="">
            </div>
        <button onclick="body1()">▶</button>
 `;
}
function leg1() {
    document.getElementById('leg').innerHTML = /*HTML*/ `
        <button onclick="leg4()">◀</button>
            <div>
                <img src="IMG/legs1.png" alt="">
            </div>
        <button onclick="leg2()">▶</button>
 `;
}
function leg2() {
    document.getElementById('leg').innerHTML = /*HTML*/ `
        <button onclick="leg1()">◀</button>
            <div>
                <img src="IMG/legs2.png" alt="">
            </div>
        <button onclick="leg3()">▶</button>
 `;
}
function leg3() {
    document.getElementById('leg').innerHTML = /*HTML*/ `
        <button onclick="leg2()">◀</button>
            <div>
                <img src="IMG/legs3.png" alt="">
            </div>
        <button onclick="leg4()">▶</button>
 `;
}
function leg4() {
    document.getElementById('leg').innerHTML = /*HTML*/ `
        <button onclick="leg3()">◀</button>
            <div>
                <img src="IMG/legs4.png" alt="">
            </div>
        <button onclick="leg1()">▶</button>
 `;
}

// visual counter
let number = 0;
function show6() {
    document.getElementById('header6').innerHTML = /*HTML*/ `
    <div class="cardgame">
        <div class="bodyparts">
            <button onclick="decreasenumber()">◀</button>   
                <div id=counter class="counter"></div>
            <button onclick="increasenumber()">▶</button>
        </div>

    </div> `
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
    document.getElementById('counter').innerHTML = number;
    ;
}
function increasenumber() {
    number++
    document.getElementById('counter').innerHTML = number;
}
function decreasenumber() {
    number--
    document.getElementById('counter').innerHTML = number;
}
// close all button
function closeall() {
    document.getElementById('header1').innerHTML = ''
    document.getElementById('header2').innerHTML = ''
    document.getElementById('header3').innerHTML = ''
    document.getElementById('header4').innerHTML = ''
    document.getElementById('header5').innerHTML = ''
}
// layout for document
function nolayout() {
    document.getElementById('layout').classList = [];

}
function vertical() {
    document.getElementById('layout').classList = [];
    document.getElementById('layout').classList.add('vertical');
}
function horizontal() {
    document.getElementById('layout').classList = [];
    document.getElementById('layout').classList.add('horizontal');
}
function grid() {
    document.getElementById('layout').classList = [];
    document.getElementById('layout').classList.add('grid');
}


