using System.Data.Common;

namespace Trinity.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TrinityDB : DbContext
    {
        public TrinityDB()
            : base("name=TrinityDB")
        {
        }

        public TrinityDB(DbConnection dbCon) : base(dbCon, true)
        {
            
        }

        public virtual DbSet<access_requirement> access_requirement { get; set; }
        public virtual DbSet<achievement_criteria_data> achievement_criteria_data { get; set; }
        public virtual DbSet<achievement_dbc> achievement_dbc { get; set; }
        public virtual DbSet<achievement_reward> achievement_reward { get; set; }
        public virtual DbSet<achievement_reward_locale> achievement_reward_locale { get; set; }
        public virtual DbSet<areatrigger_involvedrelation> areatrigger_involvedrelation { get; set; }
        public virtual DbSet<areatrigger_scripts> areatrigger_scripts { get; set; }
        public virtual DbSet<areatrigger_tavern> areatrigger_tavern { get; set; }
        public virtual DbSet<areatrigger_teleport> areatrigger_teleport { get; set; }
        public virtual DbSet<battleground_template> battleground_template { get; set; }
        public virtual DbSet<battlemaster_entry> battlemaster_entry { get; set; }
        public virtual DbSet<broadcast_text> broadcast_text { get; set; }
        public virtual DbSet<broadcast_text_locale> broadcast_text_locale { get; set; }
        public virtual DbSet<command> commands { get; set; }
        public virtual DbSet<condition> conditions { get; set; }
        public virtual DbSet<creature> creatures { get; set; }
        public virtual DbSet<creature_addon> creature_addon { get; set; }
        public virtual DbSet<creature_classlevelstats> creature_classlevelstats { get; set; }
        public virtual DbSet<creature_equip_template> creature_equip_template { get; set; }
        public virtual DbSet<creature_formations> creature_formations { get; set; }
        public virtual DbSet<creature_loot_template> creature_loot_template { get; set; }
        public virtual DbSet<creature_model_info> creature_model_info { get; set; }
        public virtual DbSet<creature_onkill_reputation> creature_onkill_reputation { get; set; }
        public virtual DbSet<creature_questender> creature_questender { get; set; }
        public virtual DbSet<creature_questitem> creature_questitem { get; set; }
        public virtual DbSet<creature_queststarter> creature_queststarter { get; set; }
        public virtual DbSet<creature_template> creature_template { get; set; }
        public virtual DbSet<creature_template_addon> creature_template_addon { get; set; }
        public virtual DbSet<creature_template_locale> creature_template_locale { get; set; }
        public virtual DbSet<creature_text> creature_text { get; set; }
        public virtual DbSet<creature_text_locale> creature_text_locale { get; set; }
        public virtual DbSet<disable> disables { get; set; }
        public virtual DbSet<disenchant_loot_template> disenchant_loot_template { get; set; }
        public virtual DbSet<exploration_basexp> exploration_basexp { get; set; }
        public virtual DbSet<fishing_loot_template> fishing_loot_template { get; set; }
        public virtual DbSet<game_event> game_event { get; set; }
        public virtual DbSet<game_event_battleground_holiday> game_event_battleground_holiday { get; set; }
        public virtual DbSet<game_event_condition> game_event_condition { get; set; }
        public virtual DbSet<game_event_creature> game_event_creature { get; set; }
        public virtual DbSet<game_event_creature_quest> game_event_creature_quest { get; set; }
        public virtual DbSet<game_event_gameobject> game_event_gameobject { get; set; }
        public virtual DbSet<game_event_gameobject_quest> game_event_gameobject_quest { get; set; }
        public virtual DbSet<game_event_model_equip> game_event_model_equip { get; set; }
        public virtual DbSet<game_event_npc_vendor> game_event_npc_vendor { get; set; }
        public virtual DbSet<game_event_npcflag> game_event_npcflag { get; set; }
        public virtual DbSet<game_event_pool> game_event_pool { get; set; }
        public virtual DbSet<game_event_prerequisite> game_event_prerequisite { get; set; }
        public virtual DbSet<game_event_quest_condition> game_event_quest_condition { get; set; }
        public virtual DbSet<game_event_seasonal_questrelation> game_event_seasonal_questrelation { get; set; }
        public virtual DbSet<game_tele> game_tele { get; set; }
        public virtual DbSet<game_weather> game_weather { get; set; }
        public virtual DbSet<gameobject> gameobjects { get; set; }
        public virtual DbSet<gameobject_addon> gameobject_addon { get; set; }
        public virtual DbSet<gameobject_loot_template> gameobject_loot_template { get; set; }
        public virtual DbSet<gameobject_questender> gameobject_questender { get; set; }
        public virtual DbSet<gameobject_questitem> gameobject_questitem { get; set; }
        public virtual DbSet<gameobject_queststarter> gameobject_queststarter { get; set; }
        public virtual DbSet<gameobject_template> gameobject_template { get; set; }
        public virtual DbSet<gameobject_template_addon> gameobject_template_addon { get; set; }
        public virtual DbSet<gameobject_template_locale> gameobject_template_locale { get; set; }
        public virtual DbSet<gossip_menu> gossip_menu { get; set; }
        public virtual DbSet<gossip_menu_option> gossip_menu_option { get; set; }
        public virtual DbSet<gossip_menu_option_locale> gossip_menu_option_locale { get; set; }
        public virtual DbSet<graveyard_zone> graveyard_zone { get; set; }
        public virtual DbSet<instance_encounters> instance_encounters { get; set; }
        public virtual DbSet<instance_spawn_groups> instance_spawn_groups { get; set; }
        public virtual DbSet<instance_template> instance_template { get; set; }
        public virtual DbSet<item_enchantment_template> item_enchantment_template { get; set; }
        public virtual DbSet<item_loot_template> item_loot_template { get; set; }
        public virtual DbSet<item_set_names> item_set_names { get; set; }
        public virtual DbSet<item_set_names_locale> item_set_names_locale { get; set; }
        public virtual DbSet<item_template> item_template { get; set; }
        public virtual DbSet<item_template_locale> item_template_locale { get; set; }
        public virtual DbSet<lfg_dungeon_rewards> lfg_dungeon_rewards { get; set; }
        public virtual DbSet<lfg_dungeon_template> lfg_dungeon_template { get; set; }
        public virtual DbSet<linked_respawn> linked_respawn { get; set; }
        public virtual DbSet<mail_level_reward> mail_level_reward { get; set; }
        public virtual DbSet<mail_loot_template> mail_loot_template { get; set; }
        public virtual DbSet<milling_loot_template> milling_loot_template { get; set; }
        public virtual DbSet<npc_spellclick_spells> npc_spellclick_spells { get; set; }
        public virtual DbSet<npc_text> npc_text { get; set; }
        public virtual DbSet<npc_text_locale> npc_text_locale { get; set; }
        public virtual DbSet<npc_trainer> npc_trainer { get; set; }
        public virtual DbSet<npc_vendor> npc_vendor { get; set; }
        public virtual DbSet<outdoorpvp_template> outdoorpvp_template { get; set; }
        public virtual DbSet<page_text> page_text { get; set; }
        public virtual DbSet<page_text_locale> page_text_locale { get; set; }
        public virtual DbSet<pet_levelstats> pet_levelstats { get; set; }
        public virtual DbSet<pet_name_generation> pet_name_generation { get; set; }
        public virtual DbSet<pickpocketing_loot_template> pickpocketing_loot_template { get; set; }
        public virtual DbSet<player_classlevelstats> player_classlevelstats { get; set; }
        public virtual DbSet<player_factionchange_achievement> player_factionchange_achievement { get; set; }
        public virtual DbSet<player_factionchange_items> player_factionchange_items { get; set; }
        public virtual DbSet<player_factionchange_quests> player_factionchange_quests { get; set; }
        public virtual DbSet<player_factionchange_reputations> player_factionchange_reputations { get; set; }
        public virtual DbSet<player_factionchange_spells> player_factionchange_spells { get; set; }
        public virtual DbSet<player_factionchange_titles> player_factionchange_titles { get; set; }
        public virtual DbSet<player_levelstats> player_levelstats { get; set; }
        public virtual DbSet<player_xp_for_level> player_xp_for_level { get; set; }
        public virtual DbSet<playercreateinfo> playercreateinfoes { get; set; }
        public virtual DbSet<playercreateinfo_action> playercreateinfo_action { get; set; }
        public virtual DbSet<playercreateinfo_item> playercreateinfo_item { get; set; }
        public virtual DbSet<playercreateinfo_skills> playercreateinfo_skills { get; set; }
        public virtual DbSet<playercreateinfo_spell_custom> playercreateinfo_spell_custom { get; set; }
        public virtual DbSet<points_of_interest> points_of_interest { get; set; }
        public virtual DbSet<points_of_interest_locale> points_of_interest_locale { get; set; }
        public virtual DbSet<pool_creature> pool_creature { get; set; }
        public virtual DbSet<pool_gameobject> pool_gameobject { get; set; }
        public virtual DbSet<pool_pool> pool_pool { get; set; }
        public virtual DbSet<pool_quest> pool_quest { get; set; }
        public virtual DbSet<pool_template> pool_template { get; set; }
        public virtual DbSet<prospecting_loot_template> prospecting_loot_template { get; set; }
        public virtual DbSet<quest_details> quest_details { get; set; }
        public virtual DbSet<quest_mail_sender> quest_mail_sender { get; set; }
        public virtual DbSet<quest_offer_reward> quest_offer_reward { get; set; }
        public virtual DbSet<quest_poi> quest_poi { get; set; }
        public virtual DbSet<quest_poi_points> quest_poi_points { get; set; }
        public virtual DbSet<quest_request_items> quest_request_items { get; set; }
        public virtual DbSet<quest_template> quest_template { get; set; }
        public virtual DbSet<quest_template_addon> quest_template_addon { get; set; }
        public virtual DbSet<quest_template_locale> quest_template_locale { get; set; }
        public virtual DbSet<reference_loot_template> reference_loot_template { get; set; }
        public virtual DbSet<reputation_reward_rate> reputation_reward_rate { get; set; }
        public virtual DbSet<reputation_spillover_template> reputation_spillover_template { get; set; }
        public virtual DbSet<script_spline_chain_meta> script_spline_chain_meta { get; set; }
        public virtual DbSet<script_spline_chain_waypoints> script_spline_chain_waypoints { get; set; }
        public virtual DbSet<script_waypoint> script_waypoint { get; set; }
        public virtual DbSet<skill_discovery_template> skill_discovery_template { get; set; }
        public virtual DbSet<skill_extra_item_template> skill_extra_item_template { get; set; }
        public virtual DbSet<skill_fishing_base_level> skill_fishing_base_level { get; set; }
        public virtual DbSet<skill_perfect_item_template> skill_perfect_item_template { get; set; }
        public virtual DbSet<skinning_loot_template> skinning_loot_template { get; set; }
        public virtual DbSet<smart_script_config> smart_script_config { get; set; }
        public virtual DbSet<smart_scripts> smart_scripts { get; set; }
        public virtual DbSet<spawn_group> spawn_group { get; set; }
        public virtual DbSet<spawn_group_template> spawn_group_template { get; set; }
        public virtual DbSet<spell_area> spell_area { get; set; }
        public virtual DbSet<spell_bonus_data> spell_bonus_data { get; set; }
        public virtual DbSet<spell_custom_attr> spell_custom_attr { get; set; }
        public virtual DbSet<spell_dbc> spell_dbc { get; set; }
        public virtual DbSet<spell_enchant_proc_data> spell_enchant_proc_data { get; set; }
        public virtual DbSet<spell_group> spell_group { get; set; }
        public virtual DbSet<spell_group_stack_rules> spell_group_stack_rules { get; set; }
        public virtual DbSet<spell_learn_spell> spell_learn_spell { get; set; }
        public virtual DbSet<spell_loot_template> spell_loot_template { get; set; }
        public virtual DbSet<spell_pet_auras> spell_pet_auras { get; set; }
        public virtual DbSet<spell_proc> spell_proc { get; set; }
        public virtual DbSet<spell_ranks> spell_ranks { get; set; }
        public virtual DbSet<spell_required> spell_required { get; set; }
        public virtual DbSet<spell_target_position> spell_target_position { get; set; }
        public virtual DbSet<spell_threat> spell_threat { get; set; }
        public virtual DbSet<spelldifficulty_dbc> spelldifficulty_dbc { get; set; }
        public virtual DbSet<transport> transports { get; set; }
        public virtual DbSet<trinity_string> trinity_string { get; set; }
        public virtual DbSet<update> updates { get; set; }
        public virtual DbSet<updates_include> updates_include { get; set; }
        public virtual DbSet<vehicle_accessory> vehicle_accessory { get; set; }
        public virtual DbSet<vehicle_template_accessory> vehicle_template_accessory { get; set; }
        public virtual DbSet<version> versions { get; set; }
        public virtual DbSet<warden_checks> warden_checks { get; set; }
        public virtual DbSet<waypoint_data> waypoint_data { get; set; }
        public virtual DbSet<waypoint_scripts> waypoint_scripts { get; set; }
        public virtual DbSet<waypoint> waypoints { get; set; }
        public virtual DbSet<creature_summon_groups> creature_summon_groups { get; set; }
        public virtual DbSet<event_scripts> event_scripts { get; set; }
        public virtual DbSet<game_event_arena_seasons> game_event_arena_seasons { get; set; }
        public virtual DbSet<playercreateinfo_cast_spell> playercreateinfo_cast_spell { get; set; }
        public virtual DbSet<spell_linked_spell> spell_linked_spell { get; set; }
        public virtual DbSet<spell_script_names> spell_script_names { get; set; }
        public virtual DbSet<spell_scripts> spell_scripts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<access_requirement>()
                .Property(e => e.quest_failed_text)
                .IsUnicode(false);

            modelBuilder.Entity<access_requirement>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_criteria_data>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_reward>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_reward>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_reward_locale>()
                .Property(e => e.Locale)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_reward_locale>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<achievement_reward_locale>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<areatrigger_scripts>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<areatrigger_tavern>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<areatrigger_teleport>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<battleground_template>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<battleground_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<broadcast_text>()
                .Property(e => e.MaleText)
                .IsUnicode(false);

            modelBuilder.Entity<broadcast_text>()
                .Property(e => e.FemaleText)
                .IsUnicode(false);

            modelBuilder.Entity<broadcast_text_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<broadcast_text_locale>()
                .Property(e => e.MaleText)
                .IsUnicode(false);

            modelBuilder.Entity<broadcast_text_locale>()
                .Property(e => e.FemaleText)
                .IsUnicode(false);

            modelBuilder.Entity<command>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<command>()
                .Property(e => e.help)
                .IsUnicode(false);

            modelBuilder.Entity<condition>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<condition>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<creature>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<creature_addon>()
                .Property(e => e.auras)
                .IsUnicode(false);

            modelBuilder.Entity<creature_classlevelstats>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<creature_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template>()
                .Property(e => e.subname)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template>()
                .Property(e => e.IconName)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template>()
                .Property(e => e.AIName)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template_addon>()
                .Property(e => e.auras)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template_locale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<creature_template_locale>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<creature_text>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<creature_text>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<creature_text_locale>()
                .Property(e => e.Locale)
                .IsUnicode(false);

            modelBuilder.Entity<creature_text_locale>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<disable>()
                .Property(e => e.params_0)
                .IsUnicode(false);

            modelBuilder.Entity<disable>()
                .Property(e => e.params_1)
                .IsUnicode(false);

            modelBuilder.Entity<disable>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<disenchant_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<fishing_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<game_event>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<game_event_condition>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<game_tele>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<game_weather>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.IconName)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.castBarCaption)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.unk1)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.AIName)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template_locale>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gameobject_template_locale>()
                .Property(e => e.castBarCaption)
                .IsUnicode(false);

            modelBuilder.Entity<gossip_menu_option>()
                .Property(e => e.OptionText)
                .IsUnicode(false);

            modelBuilder.Entity<gossip_menu_option>()
                .Property(e => e.BoxText)
                .IsUnicode(false);

            modelBuilder.Entity<gossip_menu_option_locale>()
                .Property(e => e.Locale)
                .IsUnicode(false);

            modelBuilder.Entity<gossip_menu_option_locale>()
                .Property(e => e.OptionText)
                .IsUnicode(false);

            modelBuilder.Entity<gossip_menu_option_locale>()
                .Property(e => e.BoxText)
                .IsUnicode(false);

            modelBuilder.Entity<graveyard_zone>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<instance_encounters>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<instance_template>()
                .Property(e => e.script)
                .IsUnicode(false);

            modelBuilder.Entity<item_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<item_set_names>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<item_set_names_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<item_set_names_locale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<item_template>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<item_template>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<item_template>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<item_template_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<item_template_locale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<item_template_locale>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<lfg_dungeon_template>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mail_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<milling_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text0_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text0_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text1_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text1_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text2_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text2_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text3_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text3_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text4_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text4_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text5_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text5_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text6_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text6_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text7_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text>()
                .Property(e => e.text7_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Locale)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text0_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text0_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text1_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text1_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text2_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text2_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text3_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text3_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text4_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text4_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text5_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text5_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text6_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text6_1)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text7_0)
                .IsUnicode(false);

            modelBuilder.Entity<npc_text_locale>()
                .Property(e => e.Text7_1)
                .IsUnicode(false);

            modelBuilder.Entity<outdoorpvp_template>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<outdoorpvp_template>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<page_text>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<page_text_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<page_text_locale>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<pet_name_generation>()
                .Property(e => e.word)
                .IsUnicode(false);

            modelBuilder.Entity<pickpocketing_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<player_factionchange_items>()
                .Property(e => e.commentA)
                .IsUnicode(false);

            modelBuilder.Entity<player_factionchange_items>()
                .Property(e => e.commentH)
                .IsUnicode(false);

            modelBuilder.Entity<playercreateinfo_skills>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<playercreateinfo_spell_custom>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<points_of_interest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<points_of_interest_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<points_of_interest_locale>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<pool_creature>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pool_gameobject>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pool_pool>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pool_quest>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pool_template>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<prospecting_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<quest_offer_reward>()
                .Property(e => e.RewardText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_request_items>()
                .Property(e => e.CompletionText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.LogTitle)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.LogDescription)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.QuestDescription)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.AreaDescription)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.QuestCompletionLog)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.ObjectiveText1)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.ObjectiveText2)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.ObjectiveText3)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template>()
                .Property(e => e.ObjectiveText4)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.locale)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.Details)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.Objectives)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.OfferRewardText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.RequestItemsText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.EndText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.CompletedText)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.ObjectiveText1)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.ObjectiveText2)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.ObjectiveText3)
                .IsUnicode(false);

            modelBuilder.Entity<quest_template_locale>()
                .Property(e => e.ObjectiveText4)
                .IsUnicode(false);

            modelBuilder.Entity<reference_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<script_waypoint>()
                .Property(e => e.point_comment)
                .IsUnicode(false);

            modelBuilder.Entity<skinning_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.config_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param1_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param2_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param3_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param4_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param5_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.param6_name)
                .IsUnicode(false);

            modelBuilder.Entity<smart_script_config>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<smart_scripts>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<spawn_group_template>()
                .Property(e => e.groupName)
                .IsUnicode(false);

            modelBuilder.Entity<spell_bonus_data>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<spell_dbc>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<spell_loot_template>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<transport>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<transport>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_default)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc1)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc2)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc3)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc4)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc5)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc6)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc7)
                .IsUnicode(false);

            modelBuilder.Entity<trinity_string>()
                .Property(e => e.content_loc8)
                .IsUnicode(false);

            modelBuilder.Entity<update>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<update>()
                .Property(e => e.hash)
                .IsUnicode(false);

            modelBuilder.Entity<update>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<updates_include>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<updates_include>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle_accessory>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle_template_accessory>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<version>()
                .Property(e => e.core_version)
                .IsUnicode(false);

            modelBuilder.Entity<version>()
                .Property(e => e.core_revision)
                .IsUnicode(false);

            modelBuilder.Entity<version>()
                .Property(e => e.db_version)
                .IsUnicode(false);

            modelBuilder.Entity<warden_checks>()
                .Property(e => e.data)
                .IsUnicode(false);

            modelBuilder.Entity<warden_checks>()
                .Property(e => e.str)
                .IsUnicode(false);

            modelBuilder.Entity<warden_checks>()
                .Property(e => e.result)
                .IsUnicode(false);

            modelBuilder.Entity<warden_checks>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<waypoint>()
                .Property(e => e.point_comment)
                .IsUnicode(false);

            modelBuilder.Entity<playercreateinfo_cast_spell>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<spell_linked_spell>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<spell_script_names>()
                .Property(e => e.ScriptName)
                .IsUnicode(false);
        }
    }
}
