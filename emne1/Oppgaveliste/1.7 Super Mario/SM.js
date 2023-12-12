
// model --------------------------------------------------
const model =
{
    character:
        [
            { name: "Mario", life: 100, damage: 100, leftSidepImage: "1.7 Super Mario/images/mariolookingright.png", rightSideImage: "/images/mariolookingleft.png" },
            { name: "Luigi", life: 120, damage: 80, leftSidepImage: "/images/LuigiFacingRight.png", rightSideImage: "/images/LuigiFacingLeft.png" },
            { name: "Peach", life: 200, damage: 50, leftSidepImage: '', rightSideImage: '' },
            { name: "Chuck", life: 300, damage: 40, leftSidepImage: '', rightSideImage: '' },
        ],

    powerup:
        [
            'mushroom', 'fireflower', 'Star',
        ]
};

let selectedCharacter = "";

let selectedPlayer = "";
let playerLife = null;
let playerDamage = null;
let playerImage = null;

let selectedEnemy = "";
let enemyLife = null;
let enemyDamage = null;
let enemyImage = null;

let powerup = null;

// view ---------------------------------------------------
function updateview()
{
    document.getElementById("display").innerHTML = /*HTML*/ `
        <div id="player"><img src="${playerImage == null ? "" : playerImage}"></div>
        <div id="enemy"><img src="${enemyImage == null ? "" : enemyImage}"></div>
`;
}

//controller ----------------------------------------------
function characterSelect(Name)
{
    //selectedCharacter = Name
    for (let index = 0; index < model.character.length; index++)
    {
        const Char = model.character[index];
        if (Char.name == Name && selectedPlayer == '')
        {
            selectedPlayer = Char.name;
            playerLife = Char.life;
            playerDamage = Char.damage;

            break;
        }

        if (Char.name == Name && selectedEnemy == '' && selectedPlayer !== '')
        {
            selectedEnemy = Char.name;
            enemyLife = Char.life;
            enemyDamage = Char.damage;
            enemyImage = Char.rightSideImage;
        }
    }
    updateview();
}





// function Characterselect(name)
// {
//     switch (name)
//     {
//         case 'Mario':
//             console.log("switch result: Mario")
//             if (selectedCharacter = Mario)
//             {
//                 selectedEnemy = Mario;
//                 enemyLife = 100;
//                 enemyDamage = 100;
//             }
//             else
//             {
//                 selectedCharacter = Mario;
//                 playerLife = 100;
//                 playerDamage = 100;
//             }
//             break;
//         case 'Luigi':
//             console.log("switch result:Luigi")
//             if (selectedCharacter = Luigi)
//             {
//                 selectedEnemy = Luigi;
//                 enemyLife = 120;
//                 enemyDamage = 80;
//             }
//             else
//             {
//                 selectedCharacter = Luigi;
//                 playerLife = 120;
//                 playerDamage = 80;
//             }
//             break;
//         case 'Peach':
//             console.log("switch result:Peach")
//             if (selectedCharacter = Peach)
//             {
//                 selectedEnemy = Peach;
//                 enemyLife = 200;
//                 enemyDamage = 50;
//             }
//             else
//             {
//                 selectedCharacter = Peach;
//                 playerLife = 200;
//                 playerDamage = 50;
//             }
//             break;
//         case 'Bowser':
//             console.log("switch result:Chuck")
//             if (selectedCharacter = Chuck)
//             {
//                 selectedEnemy = Chuck;
//                 enemyLife = 300;
//                 enemyDamage = 40;
//             }
//             else
//             {
//                 selectedCharacter = Chuck;
//                 playerLife = 300;
//                 playerDamage = 40;
//             }
//             break;

//         default:
//             console.log("switch result: default, Not a valid input")
//             break;
//     }

// }