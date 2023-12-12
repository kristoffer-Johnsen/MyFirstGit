
// get back to front page
/* <button onclick="document.location='/index.HTML'">back to main</button> */
// model
let tasks =
    [
        { number: '1.1', link: "/1.1 stoppeklokke/sk.HTML", name: 'stoppeklokke' },
        { number: '1.2', link: "/1.2 adjektivhistorie/Historie.HTML", name: 'adjektivhistorie' },
        { number: '1.3', link: '/1.3 Trafikklys/TL.HTML', name: 'trafikklys' },
        { number: '1.4', link: '/1.4 Soundboard/SB.HTML', name: 'soundboard' },
        { number: '1.5', link: 'noe', name: 'krokkodillespillet' },
        { number: '1.6', link: 'noe', name: 'lyspære' },
        { number: '1.7', link: 'noe', name: 'supermario' },
        { number: '1.8', link: 'noe', name: 'endredukken' },
        { number: '1.9', link: 'noe', name: 'Chatbot' },
        { number: '1.10', link: 'noe', name: 'guessthenumber' },
        { number: '1.11', link: 'noe', name: 'stein, saks, papir' },
        { number: '1.12', link: 'noe', name: 'orakelet' },
        { number: '1.13', link: 'noe', name: 'handleliste' },
        { number: '1.14', link: 'noe', name: 'pokemon catcher' },
        { number: '1.15', link: 'noe', name: 'morsekode oversetter' },
        { number: '1.16', link: 'noe', name: 'magic 8-ball' },
        { number: '1.17', link: 'noe', name: 'simon says' },
        { number: '1.18', link: 'noe', name: 'pokemon ' },
        { number: '2.1', link: 'noe', name: 'tampen brenner' },
        { number: '2.2', link: 'noe', name: 'det norske flagget' },
        { number: '2.3', link: 'noe', name: 'sjakkbrett' },
        { number: '2.4', link: 'noe', name: 'debug this' },
        //  {number:'',link:'',name:''},
    ]

// view
view()

function view()
{
    const mainview = document.getElementById("main");
    const Emne1_1 = document.getElementById("grid1");
    const Emne1_2 = document.getElementById("grid2");

    for (let index = 0; index < tasks.length; index++)
    {
        const element = tasks[index]
        if (element.number.includes('1.'))
        {
            Emne1_1.innerHTML +=/*HTML*/ `
            <button onclick="document.location='${element.link}'" class="mainbuttons">${element.name}</button>`;
        }
        else if (element.number.includes('2.'))
        {
            Emne1_2.innerHTML +=/*HTML*/ `
                <button class="mainbuttons"> ${element.name}</button >
                    `;
        }
        else
        {
            document.getElementById('main').innerHTML =/*HTML*/` <div> number other than 1. or 2.</div > `
        }
    }
}

//controller
