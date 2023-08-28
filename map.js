// === Game Data ===
var gameData = {
    commandCounter : 0,
    gameOver : false,
    introText : 'Welcome to the game!',
    outroText : 'Thanks For playing!',
    player : {
      currentLocation : 'BeginnersBastion',
      inventory : {}
    },
    map : {
      'BeginnersBastion': {
        firstVisit: true,
        displayName: "Beginner's Bastion",
        description: '',
        items: {
            Chest: {
              displayName: 'Chest',
              description: 'A weathered oak chest, etched with intricate designs, rests on the stone surface, promising untold tales within.'
            },
        },
        exits: {
            north: {
              displayName: 'North',
              destination: 'Room'
            },
            westnorthwest: {
              displayName: 'Westnorthwest',
              destination: 'Room'
            },
        },
      },
      'Room': {
        firstVisit: true,
        displayName: 'Room',
        description: '',
        items: {
            Chest: {
              displayName: 'Chest',
              description: 'On a stone, a small chest of aged oak beckons, its mysteries hidden beneath delicate engravings.'
            },
            Enemy: {
              displayName: 'Enemy',
              description: 'A small enemy'
            },
        },
        exits: {
            south: {
              displayName: 'South',
              destination: 'BeginnersBastion'
            },
            north: {
              displayName: 'North',
              destination: 'Room'
            },
        },
      },
      'Room': {
        firstVisit: true,
        displayName: 'Room',
        description: '',
        items: {
            Chest: {
              displayName: 'chest',
              description: 'An unassuming oak chest, its carvings of mythical creatures hint at the wonders concealed within its compact frame.'
            },
            Enemy: {
              displayName: 'Enemy',
              description: 'A small enemy'
            },
        },
        exits: {
            south: {
              displayName: 'South',
              destination: 'BeginnersBastion'
            },
            north: {
              displayName: 'North',
              destination: 'Room'
            },
        },
      },
      'Room': {
        firstVisit: true,
        displayName: 'Room',
        description: '',
        items: {
            Chest : {
              displayName: 'Chest ',
              description: 'A small oak chest rests, its surface worn smooth by time, guarding ancient stories within its unpretentious form.'
            },
        },
        exits: {
            east: {
              displayName: 'East',
              destination: 'Room'
            },
            southsouthwest: {
              displayName: 'Southsouthwest',
              destination: 'Room'
            },
            north: {
              displayName: 'North',
              destination: 'DarkCoridor'
            },
        },
      },
      'DarkCoridor': {
        firstVisit: true,
        displayName: 'Dark coridor',
        description: '',
        items: {
            Chest: {
              displayName: 'Chest',
              description: 'An aged oak chest, small yet captivating with its carved illustrations, rests quietly, laden with enigmatic possibilities.'
            },
            Chest: {
              displayName: 'Chest',
              description: 'Resting serenely on a stone, an unobtrusive oak chest whispers of treasures and stories concealed by its unassuming exterior.'
            },
            Enemy: {
              displayName: 'Enemy',
              description: 'Medium enemy'
            },
        },
        exits: {
            west: {
              displayName: 'West',
              destination: 'Room'
            },
            east: {
              displayName: 'East',
              destination: 'BossRoom'
            },
        },
      },
      'BossRoom': {
        firstVisit: true,
        displayName: 'Boss room',
        description: '',
        items: {
            GoldenChest: {
              displayName: 'Golden Chest',
              description: 'Behold a monumental treasure: an immense golden chest that exudes an air of magnificence.'
            },
            Boss: {
              displayName: 'Boss',
              description: 'Before you looms the boss, a sinister force in twisted form. Its malevolent aura and commanding presence exude an air of ancient power. Prepare for a pivotal battle that could reshape destinies.'
            },
        },
        exits: {
            east: {
              displayName: 'East',
              destination: 'DarkCoridor'
            },
        },
      },
    }
  };
   
  // === Game Actions ===
  var gameActions = {
  }
   
  // === Necessary Exports ===
  module.exports.gameData = gameData;
  module.exports.gameActions = gameActions;
   