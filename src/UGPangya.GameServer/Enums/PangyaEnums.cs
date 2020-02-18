﻿namespace UGPangya.GameServer
{

    #region GAMEROOM ENUMS

    public enum GameRole : byte
    {
        Normal = 0x01,
        Master = 0x08
    }

    public enum PlayerGameReady : byte
    {
        Ready = 0x00,
        UnReady = 0x01
    }

    public enum GameChangeSettings
    {
        SHIFT_NAME = 0, //ROM NAME
        SHIFT_PWD = 1,// ROM PASS
        SHIFT_GAMETYPE = 2,
        SHIFT_MAP = 3, // MAP
        SHIFT_NUMHOLE = 4, //hole TOTAL
        SHIFT_MODE = 5, //ok
        SHIFT_VSTIME = 6, //turntime(TEMPO VS)
        SHIFT_MAXPLAYER = 7,//ok
        SHIFT_MATCHTIME = 8,//TEMPO TORNEIO
        SHIFT_IDLE = 9,//??
        SHIFT_UNKNOW = 10,//DESCONHECIDO
        SHIFT_HOLENUM = 11,
        SHIFT_HOLELOCK = 12,
        SHIFT_ARTIFACT = 13, //ARTEFATO
        SHIFT_NATURAL = 14 //ok          
    }

    public enum GameMapEnum
    {
        Blue_Lagoon = 0x00,
        Blue_Water = 0x01,
        Sepia_Wind = 0x02,
        Wind_Hill = 0x03,
        Wiz_Wiz = 0x04,
        West_Wiz = 0x05,
        Blue_Moon = 0x06,
        Silvia_Cannon = 0x07,
        Ice_Cannon = 0x08,
        White_Wiz = 0x09,
        Shinning_Sand = 0x0A,
        Pink_Wind = 0x0B,
        Deep_Inferno = 0x0D,
        Ice_Spa = 0x0E,
        Lost_Seaway = 0x0F,
        Eastern_Valley = 0x10,
        Ice_Inferno = 0x12,
        Wiz_City = 0x13,
        Abbot_Mine = 0x14,
        Grand_Zodiac = 40 //mapa especial 
    }

  

   

    public enum GameCreateResultEnum : byte
    {
        CREATE_GAME_RESULT_SUCCESS = 0x00,
        CREATE_GAME_RESULT_FULL = 0x02,
        CREATE_GAME_ROOM_DONT_EXISTS = 0x03,
        CREATE_GAME_INCORRECT_PASSWORD = 0x04,
        CREATE_GAME_INVALID_LEVEL = 0x05,
        CREATE_GAME_CREATE_FAILED = 0x07,
        CREATE_GAME_ALREADY_STARTED = 0x08,
        CREATE_GAME_CREATE_FAILED2 = 0x09,
        CREATE_GAME_NEED_REGISTER_WITH_GUILD = 0x0D,
        CREATE_GAME_PANG_BATTLE_INSSUFICENT_PANGS = 0x0F,
        CREATE_GAME_APPROACH_INSSUFICENT_PANGS = 0x11,
        CREATE_GAME_CANT_CREATE = 0x12
    }


    #endregion

    #region PLAYER_ACTION 63 00

    /// <summary>
    /// PLAYER_ACTION
    /// </summary>
    public enum TPLAYER_ACTION
    {
        PLAYER_ACTION_ROTATION = 0x00,
        PLAYER_ACTION_UNK = 0x01,
        PLAYER_ACTION_APPEAR = 0x04, //APARECER
        PLAYER_ACTION_SUB = 0x05,
        PLAYER_ACTION_MOVE = 0x06,
        PLAYER_ACTION_ANIMATION = 0x07,
        PLAYER_ACTION_ANIMATION_2 = 0x08,
        PLAYER_ANIMATION_WITH_EFFECTS = 0x0A
    }

    /// <summary>
    /// PLAYER_ACTION_SUB (SUBActions)
    /// </summary>
    public enum TPLAYER_ACTION_SUB
    {
        PLAYER_ACTION_SUB_STAND = 0x00,
        PLAYER_ACTION_SUB_SIT = 0x01,
        PLAYER_ACTION_SUB_SLEEP = 0x02
    }
    #endregion

    #region PROJECTG PACKETS ID ENUM

    /// <summary>
    /// Packets enviados do jogo para o Game Server
    /// </summary>
    /// 
    public enum GamePacketEnum
    {
        PLAYER_LOGIN = 0x0002,
        PLAYER_CHAT = 0x0003,
        PLAYER_SELECT_LOBBY = 0x0004,

        PLAYER_CREATE_GAME = 0x0008,
        PLAYER_JOIN_GAME = 0x0009,

        PLAYER_CHANGE_NICKNAME = 0x0038,
        PLAYER_EXCEPTION = 0x33,
        PLAYER_JOIN_MULTIGAME_LIST = 0x0081,
        PLAYER_LEAVE_MULTIGAME_LIST = 0x0082,
        PLAYER_REQUEST_MESSENGER_LIST = 0x008B,
        PLAYER_JOIN_MULTIGAME_GRANDPRIX = 0x0176,
        PLAYER_LEAVE_MULTIGAME_GRANDPRIX = 0x0177,
        PLAYER_ENTER_GRANDPRIX = 0x0179,
        PLAYER_OPEN_PAPEL = 0x0098,
        PLAYER_OPEN_NORMAL_BONGDARI = 0x014B,
        PLAYER_OPEN_BIG_BONGDARI = 0x0186,
        PLAYER_SAVE_MACRO = 0x0069,
        PLAYER_OPEN_MAILBOX = 0x0143,
        PLAYER_READ_MAIL = 0x0144,
        PLAYER_RELEASE_MAILITEM = 0x0146,
        PLAYER_DELETE_MAIL = 0x0147,
        PLAYER_GM_COMMAND = 0x008F,
        // {GAME PROCESS    }
        PLAYER_USE_ITEM = 0x0017,
        PLAYER_PRESS_READY = 0x000D,
        PLAYER_START_GAME = 0x000E,
        PLAYER_LEAVE_GAME = 0x000F,
        PLAYER_KEEPLIVE = 0xF4,
        PLAYER_LOAD_OK = 0x0011,
        PLAYER_SHOT_DATA = 0x001B,
        PLAYER_ENTER_TO_ROOM = 0x00EB, // { MAY BE USE FOR CHAT ROOM ONLY  }
        PLAYER_ACTION = 0x0063,
        PLAYER_CLOSE_SHOP = 0x0075,
        PLAYER_EDIT_SHOP = 0x0076,
        PLAYER_MASTER_KICK_PLAYER = 0x0026,
        PLAYER_CHANGE_GAME_OPTION = 0x000A,
        PLAYER_LEAVE_GRANDPRIX = 0x017A,
        PLAYER_AFTER_UPLOAD_UCC = 0x00B9,
        PLAYER_REQUEST_UPLOAD_KEY = 0x00C9,
        PLAYER_1ST_SHOT_READY = 0x0034,
        PLAYER_LOADING_INFO = 0x0048,
        PLAYER_GAME_ROTATE = 0x0013,
        PLAYER_CHANGE_CLUB = 0x0016,
        PLAYER_GAME_MARK = 0x012E,
        PLAYER_ACTION_SHOT = 0x0012,
        PLAYER_SHOT_SYNC = 0x001C,
        PLAYER_HOLE_INFORMATIONS = 0x001A,
        PLAYER_MY_TURN = 0x0022,
        PLAYER_HOLE_COMPLETE = 0x0031,
        PLAYER_CHAT_ICON = 0x0018,
        PLAYER_SLEEP_ICON = 0x0032,
        PLAYER_MATCH_DATA = 0x012F,
        PLAYER_MOVE_BAR = 0x0014,
        PLAYER_PAUSE_GAME = 0x0030,
        PLAYER_QUIT_SINGLE_PLAYER = 0x0130,
        PLAYER_CALL_ASSIST_PUTTING = 0x0185,
        PLAYER_USE_TIMEBOOSTER = 0x0065,
        PLAYER_DROP_BALL = 0x0019,
        PLAYER_CHANGE_TEAM = 0x0010,
        PLAYER_VERSUS_TEAM_SCORE = 0x0035,
        PLAYER_POWER_SHOT = 0x0015,
        PLAYER_WIND_CHANGE = 0x0141,
        PLAYER_SEND_GAMERESULT = 0x0006,

        //{ITEM SPECIAL}
        PLAYER_REQUEST_ANIMALHAND_EFFECT = 0x015C,

        PLAYER_BUY_ITEM_GAME = 0x001D,
        PLAYER_ENTER_TO_SHOP = 0x0140,
        PLAYER_CHECK_USER_FOR_GIFT = 0x0007,

        PLAYER_SAVE_BAR = 0x000B,
        PLAYER_CHANGE_EQUIPMENT = 0x000C,
        PLAYER_CHANGE_EQUIPMENTS = 0x0020,

        PLAYER_WHISPER = 0x002A,
        PLAYER_REQUEST_TIME = 0x005C,
        PLAYER_GM_DESTROY_ROOM = 0x0060,
        PLAYER_GM_KICK_USER = 0x0061,
        PLAYER_REQUEST_LOBBY_INFO = 0x0043,
        PLAYER_REMOVE_ITEM = 0x0064,
        PLAYER_PLAY_AZTEC_BOX = 0x00EC,
        PLAYER_OPEN_BOX = 0x00EF,
        PLAYER_CHANGE_SERVER = 0x0119,
        PLAYER_ASSIST_CONTROL = 0x0184,
        PLAYER_SELECT_LOBBY_WITH_ENTER_CHANNEL = 0x0083,
        PLAYER_REQUEST_GAMEINFO = 0x002D,
        PLAYER_GM_SEND_NOTICE = 0x0057,
        PLAYER_REQUEST_PLAYERINFO = 0x002F,
        PLAYER_CHANGE_MASCOT_MESSAGE = 0x0073,
        PLAYER_ENTER_ROOM = 0x00B5,
        PLAYER_ENTER_ROOM_GETINFO = 0x00B7,

        PLAYER_OPENUP_SCRATCHCARD = 0x012A,
        PLAYER_PLAY_SCRATCHCARD = 0x0070,


        PLAYER_FIRST_SET_LOCKER = 0x00D0,
        PLAYER_ENTER_TO_LOCKER = 0x00D3,
        PLAYER_OPEN_LOCKER = 0x00CC,
        PLAYER_CHANGE_LOCKERPWD = 0x00D1,
        PLAYER_GET_LOCKERPANG = 0x00D5,
        PLAYER_LOCKERPANG_CONTROL = 0x00D4,
        PLAYER_CALL_LOCKERITEMLIST = 0x00CD,
        PLAYER_PUT_ITEMLOCKER = 0x00CE,
        PLAYER_TAKE_ITEMLOCKER = 0x00CF,

        // CLUB
        PLAYER_UPGRADE_CLUB = 0x0164,
        PLAYER_UPGRADE_ACCEPT = 0x0165,
        PLAYER_UPGRADE_CALCEL = 0x0166,
        PLAYER_UPGRADE_RANK = 0x0167,
        PLAYER_TRASAFER_CLUBPOINT = 0x016C,
        PLAYER_CLUBSET_ABBOT = 0x016B,
        PLAYER_CLUBSET_POWER = 0x016D,
        PLAYER_CHANGE_INTRO = 0x0106,
        PLAYER_CHANGE_NOTICE = 0x0105,
        PLAYER_CHANGE_SELFINTRO = 0x0111,
        PLAYER_LEAVE_GUILD = 0x0113,
        PLAYER_UPGRADE_CLUB_SLOT = 0x004B,

        // GUILD SYSTEM
        PLAYER_CALL_GUILD_LIST = 0x0108,
        PLAYER_SEARCH_GUILD = 0x0109,
        PLAYER_GUILD_AVAIABLE = 0x0102,
        PLAYER_CREATE_GUILD = 0x0101,
        PLAYER_REQUEST_GUILDDATA = 0x0104,
        PLAYER_GUILD_GET_PLAYER = 0x0112,
        PLAYER_GUILD_LOG = 0x010A,
        PLAYER_JOIN_GUILD = 0x010C,
        PLAYER_CANCEL_JOIN_GUILD = 0x010D,
        PLAYER_GUILD_ACCEPT = 0x010E,
        PLAYER_GUILD_KICK = 0x0114,
        PLAYER_GUILD_PROMOTE = 0x0110,
        PLAYER_GUILD_DESTROY = 0x0107,
        PLAYER_GUILD_CALL_UPLOAD = 0x0115,
        PLAYER_GUILD_CALL_AFTER_UPLOAD = 0x0116,

        // DIALY LOGIN
        PLAYER_REQUEST_CHECK_DAILY_ITEM = 0x016E,
        PLAYER_REQUEST_ITEM_DAILY = 0x016F,

        // ACHIEVEMENT
        PLAYER_CALL_ACHIEVEMENT = 0x0157,

        // Tiki Report
        PLAYER_OPEN_TIKIREPORT = 0x00AB,

        // UNKNOWN YET
        PLAYER_REQUEST_UNKNOWN = 0x00C1,

        // Memorial
        PLAYER_MEMORIAL = 0x017F,

        // Card Pack Open
        PLAYER_OPEN_CARD = 0x00CA,
        PLAYER_CARD_SPECIAL = 0x00BD,

        PLAYER_CALL_CUTIN = 0x00E5,

        // Magic Box
        PLAYER_DO_MAGICBOX = 0x0158,

        // RENT ITEM
        PLAYER_RENEW_RENT = 0x00E6,
        PLAYER_DELETE_RENT = 0x00E7,

        // QUEST
        PLAYER_LOAD_QUEST = 0x0151,
        PLAYER_ACCEPT_QUEST = 0x0152,

        // CARD INSERT
        PLAYER_PUT_CARD = 0x018A,
        PLAYER_PUT_BONUS_CARD = 0x018B,
        PLAYER_REMOVE_CARD = 0x018C,

        PLAYER_MATCH_HISTORY = 0x009C,

        // TOP NOTICE
        PLAYER_SEND_TOP_NOTICE = 0x0066,
        PLAYER_CHECK_NOTICE_COOKIE = 0x0067,

        PLAYER_UPGRADE_STATUS = 0x0188,
        PLAYER_DOWNGRADE_STATUS = 0x0189
    }

    #endregion

}
