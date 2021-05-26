namespace XPlaneConnector.DataRefs
{
    public sealed class Commands
    {
        public static XPlaneCommand NoneNone { get { return new XPlaneCommand("sim/none/none", "Do nothing."); } }
        public static XPlaneCommand OperationQuit { get { return new XPlaneCommand("sim/operation/quit", "Quit X-Plane."); } }
        public static XPlaneCommand OperationScreenshot { get { return new XPlaneCommand("sim/operation/screenshot", "Take a screenshot."); } }
        public static XPlaneCommand OperationShowMenu { get { return new XPlaneCommand("sim/operation/show_menu", "Show the in-sim menu."); } }
        public static XPlaneCommand OperationMakeCurrentAircraftIcons { get { return new XPlaneCommand("sim/operation/make_current_aircraft_icons", "(Re)generate all icons for the current aircraft."); } }
        public static XPlaneCommand OperationMakeSingleIcon { get { return new XPlaneCommand("sim/operation/make_single_icon", "(Re)generate the icon for the current aircraft & livery."); } }
        public static XPlaneCommand OperationMakeMissingIcons { get { return new XPlaneCommand("sim/operation/make_missing_icons", "Generate all missing aircraft & livery icons."); } }
        public static XPlaneCommand OperationRegenWeather { get { return new XPlaneCommand("sim/operation/regen_weather", "Regenerate weather."); } }
        public static XPlaneCommand OperationCycleDump { get { return new XPlaneCommand("sim/operation/cycle_dump", "Print out a cycle dump for this frame."); } }
        public static XPlaneCommand OperationStabDerivPitch { get { return new XPlaneCommand("sim/operation/stab_deriv_pitch", "Print longitudinal stability derivative."); } }
        public static XPlaneCommand OperationStabDerivHeading { get { return new XPlaneCommand("sim/operation/stab_deriv_heading", "Print lateral stability derivative."); } }
        public static XPlaneCommand OperationRecording { get { return new XPlaneCommand("sim/operation/recording", "Toggle user interaction recording pane."); } }
        public static XPlaneCommand OperationCreateSnapMarker { get { return new XPlaneCommand("sim/operation/create_snap_marker", "Drop a snapshot marker for replay mode."); } }
        public static XPlaneCommand OperationTestDataRef { get { return new XPlaneCommand("sim/operation/test_data_ref", "Test dataref: Run from 0 to 1 and back."); } }
        public static XPlaneCommand OperationShowFps { get { return new XPlaneCommand("sim/operation/show_fps", "Toggle on-screen frame-rate display."); } }
        public static XPlaneCommand OperationDevConsole { get { return new XPlaneCommand("sim/operation/dev_console", "Toggle dev console."); } }
        public static XPlaneCommand OperationToggleFullScreen { get { return new XPlaneCommand("sim/operation/toggle_full_screen", "Toggle full-screen mode."); } }
        public static XPlaneCommand OperationReloadAircraft { get { return new XPlaneCommand("sim/operation/reload_aircraft", "Force reloading the current aircraft (including art)."); } }
        public static XPlaneCommand OperationReloadAircraftNoArt { get { return new XPlaneCommand("sim/operation/reload_aircraft_no_art", "Force reloading the current aircraft (skip art reload)."); } }
        public static XPlaneCommand OperationReloadScenery { get { return new XPlaneCommand("sim/operation/reload_scenery", "Force reloading the current scenery."); } }
        public static XPlaneCommand OperationLoadRealWeather { get { return new XPlaneCommand("sim/operation/load_real_weather", "Scan real weather files."); } }
        public static XPlaneCommand OperationFailSystem { get { return new XPlaneCommand("sim/operation/fail_system", "Fail selected in failures screen."); } }
        public static XPlaneCommand OperationMakePanelPreviews { get { return new XPlaneCommand("sim/operation/make_panel_previews", "Make screenshots of your panels."); } }
        public static XPlaneCommand OperationCloseWindows { get { return new XPlaneCommand("sim/operation/close_windows", "Close any windows to get back to cockpit."); } }
        public static XPlaneCommand OperationLoadSituation1 { get { return new XPlaneCommand("sim/operation/load_situation_1", "Load situation."); } }
        public static XPlaneCommand OperationLoadSituation2 { get { return new XPlaneCommand("sim/operation/load_situation_2", "Load situation."); } }
        public static XPlaneCommand OperationLoadSituation3 { get { return new XPlaneCommand("sim/operation/load_situation_3", "Load situation."); } }
        public static XPlaneCommand ViewTrackIrToggle { get { return new XPlaneCommand("sim/view/track-ir_toggle", "Toggle TrackIR control."); } }
        public static XPlaneCommand MapShowCurrent { get { return new XPlaneCommand("sim/map/show_current", "Toggle the map window."); } }
        public static XPlaneCommand MapShowInstructorOperatorStation { get { return new XPlaneCommand("sim/map/show_instructor_operator_station", "Toggle the instructor operator station (IOS) window."); } }
        public static XPlaneCommand MapShowLowEnroute { get { return new XPlaneCommand("sim/map/show_low_enroute", "Toggle the low enroute map."); } }
        public static XPlaneCommand MapShowHighEnroute { get { return new XPlaneCommand("sim/map/show_high_enroute", "Toggle the high enroute map."); } }
        public static XPlaneCommand MapShowSectional { get { return new XPlaneCommand("sim/map/show_sectional", "Toggle the sectional map."); } }
        public static XPlaneCommand OperationToggleFlightConfig { get { return new XPlaneCommand("sim/operation/toggle_flight_config", "Toggle the Flight Configuration window."); } }
        public static XPlaneCommand OperationToggleMainMenu { get { return new XPlaneCommand("sim/operation/toggle_main_menu", "Toggle the Main Menu screen."); } }
        public static XPlaneCommand OperationToggleSettingsWindow { get { return new XPlaneCommand("sim/operation/toggle_settings_window", "Toggle the Settings window."); } }
        public static XPlaneCommand OperationToggleFlightSchoolWindow { get { return new XPlaneCommand("sim/operation/toggle_flight_school_window", "Toggle the Flight School window."); } }
        public static XPlaneCommand OperationToggleKeyShortcutsWindow { get { return new XPlaneCommand("sim/operation/toggle_key_shortcuts_window", "Toggle the Keyboard Shortcuts window."); } }
        public static XPlaneCommand OperationOpenWeightAndBalanceWindow { get { return new XPlaneCommand("sim/operation/open_weight_and_balance_window", "Open the Weight & Balance window."); } }
        public static XPlaneCommand OperationOpenFailuresWindow { get { return new XPlaneCommand("sim/operation/open_failures_window", "Open the Failures window."); } }
        public static XPlaneCommand OperationToggleDataOutputGraph { get { return new XPlaneCommand("sim/operation/toggle_data_output_graph", "Toggle display of the data output graph."); } }
        public static XPlaneCommand OperationToggleDataOutputCockpit { get { return new XPlaneCommand("sim/operation/toggle_data_output_cockpit", "Toggle display of the cockpit data output."); } }
        public static XPlaneCommand OperationToggleJoyProfilesWindow { get { return new XPlaneCommand("sim/operation/toggle_joy_profiles_window", "Toggle the keyboard & joystick profiles window."); } }
        public static XPlaneCommand OperationToggleCustomLocationWindow { get { return new XPlaneCommand("sim/operation/toggle_custom_location_window", "Toggle the Location details window."); } }
        public static XPlaneCommand OperationToggleStyleGuide { get { return new XPlaneCommand("sim/operation/toggle_style_guide", "Toggle display of the V11 UI style guide."); } }
        public static XPlaneCommand OperationSlider01 { get { return new XPlaneCommand("sim/operation/slider_01", "Slider #1 On/Off control."); } }
        public static XPlaneCommand OperationSlider02 { get { return new XPlaneCommand("sim/operation/slider_02", "Slider #2 On/Off control."); } }
        public static XPlaneCommand OperationSlider03 { get { return new XPlaneCommand("sim/operation/slider_03", "Slider #3 On/Off control."); } }
        public static XPlaneCommand OperationSlider04 { get { return new XPlaneCommand("sim/operation/slider_04", "Slider #4 On/Off control."); } }
        public static XPlaneCommand OperationSlider05 { get { return new XPlaneCommand("sim/operation/slider_05", "Slider #5 On/Off control."); } }
        public static XPlaneCommand OperationSlider06 { get { return new XPlaneCommand("sim/operation/slider_06", "Slider #6 On/Off control."); } }
        public static XPlaneCommand OperationSlider07 { get { return new XPlaneCommand("sim/operation/slider_07", "Slider #7 On/Off control."); } }
        public static XPlaneCommand OperationSlider08 { get { return new XPlaneCommand("sim/operation/slider_08", "Slider #8 On/Off control."); } }
        public static XPlaneCommand OperationSlider09 { get { return new XPlaneCommand("sim/operation/slider_09", "Slider #9 On/Off control."); } }
        public static XPlaneCommand OperationSlider10 { get { return new XPlaneCommand("sim/operation/slider_10", "Slider #10 On/Off control."); } }
        public static XPlaneCommand OperationSlider11 { get { return new XPlaneCommand("sim/operation/slider_11", "Slider #11 On/Off control."); } }
        public static XPlaneCommand OperationSlider12 { get { return new XPlaneCommand("sim/operation/slider_12", "Slider #12 On/Off control."); } }
        public static XPlaneCommand OperationSlider13 { get { return new XPlaneCommand("sim/operation/slider_13", "Slider #13 On/Off control."); } }
        public static XPlaneCommand OperationSlider14 { get { return new XPlaneCommand("sim/operation/slider_14", "Slider #14 On/Off control."); } }
        public static XPlaneCommand OperationSlider15 { get { return new XPlaneCommand("sim/operation/slider_15", "Slider #15 On/Off control."); } }
        public static XPlaneCommand OperationSlider16 { get { return new XPlaneCommand("sim/operation/slider_16", "Slider #16 On/Off control."); } }
        public static XPlaneCommand OperationSlider17 { get { return new XPlaneCommand("sim/operation/slider_17", "Slider #17 On/Off control."); } }
        public static XPlaneCommand OperationSlider18 { get { return new XPlaneCommand("sim/operation/slider_18", "Slider #18 On/Off control."); } }
        public static XPlaneCommand OperationSlider19 { get { return new XPlaneCommand("sim/operation/slider_19", "Slider #19 On/Off control."); } }
        public static XPlaneCommand OperationSlider20 { get { return new XPlaneCommand("sim/operation/slider_20", "Slider #20 On/Off control."); } }
        public static XPlaneCommand OperationSlider21 { get { return new XPlaneCommand("sim/operation/slider_21", "Slider #21 On/Off control."); } }
        public static XPlaneCommand OperationSlider22 { get { return new XPlaneCommand("sim/operation/slider_22", "Slider #22 On/Off control."); } }
        public static XPlaneCommand OperationSlider23 { get { return new XPlaneCommand("sim/operation/slider_23", "Slider #23 On/Off control."); } }
        public static XPlaneCommand OperationSlider24 { get { return new XPlaneCommand("sim/operation/slider_24", "Slider #24 On/Off control."); } }
        public static XPlaneCommand OperationFixAllSystems { get { return new XPlaneCommand("sim/operation/fix_all_systems", "Fix all failed systems."); } }
        public static XPlaneCommand OperationAutoBoard { get { return new XPlaneCommand("sim/operation/auto_board", "Auto-set electrical system for boarding."); } }
        public static XPlaneCommand OperationAutoStart { get { return new XPlaneCommand("sim/operation/auto_start", "Auto-start engines to running, real-time."); } }
        public static XPlaneCommand OperationQuickStart { get { return new XPlaneCommand("sim/operation/quick_start", "Quick-start engines to running."); } }
        public static XPlaneCommand MagnetosMagnetosOff { get { return new XPlaneCommand("sim/magnetos/magnetos_off", "Magnetos off."); } }
        public static XPlaneCommand MagnetosMagnetosBoth { get { return new XPlaneCommand("sim/magnetos/magnetos_both", "Magnetos both."); } }
        public static XPlaneCommand EnginesEngageStarters { get { return new XPlaneCommand("sim/engines/engage_starters", "Engage starters."); } }
        public static XPlaneCommand EnginesThrottleDown { get { return new XPlaneCommand("sim/engines/throttle_down", "Throttle down a bit."); } }
        public static XPlaneCommand EnginesThrottleUp { get { return new XPlaneCommand("sim/engines/throttle_up", "Throttle up a bit."); } }
        public static XPlaneCommand EnginesTOGAPower { get { return new XPlaneCommand("sim/engines/TOGA_power", "Engage TOGA power."); } }
        public static XPlaneCommand EnginesPropDown { get { return new XPlaneCommand("sim/engines/prop_down", "Prop coarse a bit."); } }
        public static XPlaneCommand EnginesPropUp { get { return new XPlaneCommand("sim/engines/prop_up", "Prop fine a bit."); } }
        public static XPlaneCommand EnginesMixtureMin { get { return new XPlaneCommand("sim/engines/mixture_min", "Mixture to cut off."); } }
        public static XPlaneCommand EnginesMixtureDown { get { return new XPlaneCommand("sim/engines/mixture_down", "Mixture lean a bit."); } }
        public static XPlaneCommand EnginesMixtureUp { get { return new XPlaneCommand("sim/engines/mixture_up", "Mixture rich a bit."); } }
        public static XPlaneCommand EnginesMixtureMax { get { return new XPlaneCommand("sim/engines/mixture_max", "Mixture to full rich."); } }
        public static XPlaneCommand EnginesCarbHeatOff { get { return new XPlaneCommand("sim/engines/carb_heat_off", "Carb heat off."); } }
        public static XPlaneCommand EnginesCarbHeatOn { get { return new XPlaneCommand("sim/engines/carb_heat_on", "Carb heat on."); } }
        public static XPlaneCommand EnginesCarbHeatToggle { get { return new XPlaneCommand("sim/engines/carb_heat_toggle", "Carb heat toggle."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open", "Move cowl flaps open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed", "Move cowl flaps to closed a bit."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle", "Idle high/low toggle."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle1 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_1", "Idle high/low toggle Engine 1."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle2 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_2", "Idle high/low toggle Engine 2."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle3 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_3", "Idle high/low toggle Engine 3."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle4 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_4", "Idle high/low toggle Engine 4."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle5 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_5", "Idle high/low toggle Engine 5."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle6 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_6", "Idle high/low toggle Engine 6."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle7 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_7", "Idle high/low toggle Engine 7."); } }
        public static XPlaneCommand EnginesIdleHiLoToggle8 { get { return new XPlaneCommand("sim/engines/idle_hi_lo_toggle_8", "Idle high/low toggle Engine 8."); } }
        public static XPlaneCommand FadecFadecToggle { get { return new XPlaneCommand("sim/fadec/fadec_toggle", "FADEC toggle."); } }
        public static XPlaneCommand EnginesGovernorOn { get { return new XPlaneCommand("sim/engines/governor_on", "Throttle governor on."); } }
        public static XPlaneCommand EnginesGovernorOff { get { return new XPlaneCommand("sim/engines/governor_off", "Throttle governor off."); } }
        public static XPlaneCommand EnginesGovernorToggle { get { return new XPlaneCommand("sim/engines/governor_toggle", "Throttle governor toggle."); } }
        public static XPlaneCommand EnginesClutchOn { get { return new XPlaneCommand("sim/engines/clutch_on", "Clutch on."); } }
        public static XPlaneCommand EnginesClutchOff { get { return new XPlaneCommand("sim/engines/clutch_off", "Clutch off."); } }
        public static XPlaneCommand EnginesClutchToggle { get { return new XPlaneCommand("sim/engines/clutch_toggle", "Clutch toggle."); } }
        public static XPlaneCommand EnginesBetaToggle { get { return new XPlaneCommand("sim/engines/beta_toggle", "Toggle Beta prop."); } }
        public static XPlaneCommand EnginesThrustReverseToggle { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle", "Toggle thrust reversers."); } }
        public static XPlaneCommand EnginesThrustReverseHold { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold", "Hold thrust reverse at max."); } }
        public static XPlaneCommand StartersShutDown { get { return new XPlaneCommand("sim/starters/shut_down", "Pull fuel and mags for shutdown."); } }
        public static XPlaneCommand MagnetosMagnetosDown1 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_1", "Magnetos down one notch for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosDown2 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_2", "Magnetos down one notch for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosDown3 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_3", "Magnetos down one notch for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosDown4 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_4", "Magnetos down one notch for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosDown5 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_5", "Magnetos down one notch for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosDown6 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_6", "Magnetos down one notch for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosDown7 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_7", "Magnetos down one notch for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosDown8 { get { return new XPlaneCommand("sim/magnetos/magnetos_down_8", "Magnetos down one notch for engine #8."); } }
        public static XPlaneCommand MagnetosMagnetosUp1 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_1", "Magnetos up one notch for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosUp2 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_2", "Magnetos up one notch for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosUp3 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_3", "Magnetos up one notch for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosUp4 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_4", "Magnetos up one notch for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosUp5 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_5", "Magnetos up one notch for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosUp6 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_6", "Magnetos up one notch for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosUp7 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_7", "Magnetos up one notch for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosUp8 { get { return new XPlaneCommand("sim/magnetos/magnetos_up_8", "Magnetos up one notch for engine #8."); } }
        public static XPlaneCommand MagnetosMagnetosOff1 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_1", "Magnetos off for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosOff2 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_2", "Magnetos off for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosOff3 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_3", "Magnetos off for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosOff4 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_4", "Magnetos off for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosOff5 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_5", "Magnetos off for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosOff6 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_6", "Magnetos off for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosOff7 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_7", "Magnetos off for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosOff8 { get { return new XPlaneCommand("sim/magnetos/magnetos_off_8", "Magnetos off for engine #8."); } }
        public static XPlaneCommand MagnetosMagnetosLeft1 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_1", "Magnetos left for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosLeft2 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_2", "Magnetos left for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosLeft3 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_3", "Magnetos left for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosLeft4 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_4", "Magnetos left for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosLeft5 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_5", "Magnetos left for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosLeft6 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_6", "Magnetos left for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosLeft7 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_7", "Magnetos left for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosLeft8 { get { return new XPlaneCommand("sim/magnetos/magnetos_left_8", "Magnetos left for engine #8."); } }
        public static XPlaneCommand MagnetosMagnetosRight1 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_1", "Magnetos right for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosRight2 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_2", "Magnetos right for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosRight3 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_3", "Magnetos right for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosRight4 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_4", "Magnetos right for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosRight5 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_5", "Magnetos right for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosRight6 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_6", "Magnetos right for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosRight7 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_7", "Magnetos right for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosRight8 { get { return new XPlaneCommand("sim/magnetos/magnetos_right_8", "Magnetos right for engine #8."); } }
        public static XPlaneCommand MagnetosMagnetosBoth1 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_1", "Magnetos both for engine #1."); } }
        public static XPlaneCommand MagnetosMagnetosBoth2 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_2", "Magnetos both for engine #2."); } }
        public static XPlaneCommand MagnetosMagnetosBoth3 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_3", "Magnetos both for engine #3."); } }
        public static XPlaneCommand MagnetosMagnetosBoth4 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_4", "Magnetos both for engine #4."); } }
        public static XPlaneCommand MagnetosMagnetosBoth5 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_5", "Magnetos both for engine #5."); } }
        public static XPlaneCommand MagnetosMagnetosBoth6 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_6", "Magnetos both for engine #6."); } }
        public static XPlaneCommand MagnetosMagnetosBoth7 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_7", "Magnetos both for engine #7."); } }
        public static XPlaneCommand MagnetosMagnetosBoth8 { get { return new XPlaneCommand("sim/magnetos/magnetos_both_8", "Magnetos both for engine #8."); } }
        public static XPlaneCommand IgnitionIgnitionDown1 { get { return new XPlaneCommand("sim/ignition/ignition_down_1", "Ignition key down one notch for engine #1."); } }
        public static XPlaneCommand IgnitionIgnitionDown2 { get { return new XPlaneCommand("sim/ignition/ignition_down_2", "Ignition key down one notch for engine #2."); } }
        public static XPlaneCommand IgnitionIgnitionDown3 { get { return new XPlaneCommand("sim/ignition/ignition_down_3", "Ignition key down one notch for engine #3."); } }
        public static XPlaneCommand IgnitionIgnitionDown4 { get { return new XPlaneCommand("sim/ignition/ignition_down_4", "Ignition key down one notch for engine #4."); } }
        public static XPlaneCommand IgnitionIgnitionDown5 { get { return new XPlaneCommand("sim/ignition/ignition_down_5", "Ignition key down one notch for engine #5."); } }
        public static XPlaneCommand IgnitionIgnitionDown6 { get { return new XPlaneCommand("sim/ignition/ignition_down_6", "Ignition key down one notch for engine #6."); } }
        public static XPlaneCommand IgnitionIgnitionDown7 { get { return new XPlaneCommand("sim/ignition/ignition_down_7", "Ignition key down one notch for engine #7."); } }
        public static XPlaneCommand IgnitionIgnitionDown8 { get { return new XPlaneCommand("sim/ignition/ignition_down_8", "Ignition key down one notch for engine #8."); } }
        public static XPlaneCommand IgnitionIgnitionUp1 { get { return new XPlaneCommand("sim/ignition/ignition_up_1", "Ignition key up one notch for engine #1."); } }
        public static XPlaneCommand IgnitionIgnitionUp2 { get { return new XPlaneCommand("sim/ignition/ignition_up_2", "Ignition key up one notch for engine #2."); } }
        public static XPlaneCommand IgnitionIgnitionUp3 { get { return new XPlaneCommand("sim/ignition/ignition_up_3", "Ignition key up one notch for engine #3."); } }
        public static XPlaneCommand IgnitionIgnitionUp4 { get { return new XPlaneCommand("sim/ignition/ignition_up_4", "Ignition key up one notch for engine #4."); } }
        public static XPlaneCommand IgnitionIgnitionUp5 { get { return new XPlaneCommand("sim/ignition/ignition_up_5", "Ignition key up one notch for engine #5."); } }
        public static XPlaneCommand IgnitionIgnitionUp6 { get { return new XPlaneCommand("sim/ignition/ignition_up_6", "Ignition key up one notch for engine #6."); } }
        public static XPlaneCommand IgnitionIgnitionUp7 { get { return new XPlaneCommand("sim/ignition/ignition_up_7", "Ignition key up one notch for engine #7."); } }
        public static XPlaneCommand IgnitionIgnitionUp8 { get { return new XPlaneCommand("sim/ignition/ignition_up_8", "Ignition key up one notch for engine #8."); } }
        public static XPlaneCommand IgnitersIgniterArmOff1 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_1", "Igniter #1 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff2 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_2", "Igniter #2 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff3 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_3", "Igniter #3 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff4 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_4", "Igniter #4 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff5 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_5", "Igniter #5 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff6 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_6", "Igniter #6 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff7 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_7", "Igniter #7 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOff8 { get { return new XPlaneCommand("sim/igniters/igniter_arm_off_8", "Igniter #8 arm off."); } }
        public static XPlaneCommand IgnitersIgniterArmOn1 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_1", "Igniter #1 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn2 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_2", "Igniter #2 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn3 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_3", "Igniter #3 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn4 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_4", "Igniter #4 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn5 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_5", "Igniter #5 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn6 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_6", "Igniter #6 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn7 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_7", "Igniter #7 arm on."); } }
        public static XPlaneCommand IgnitersIgniterArmOn8 { get { return new XPlaneCommand("sim/igniters/igniter_arm_on_8", "Igniter #8 arm on."); } }
        public static XPlaneCommand IgnitersIgniterContinOff1 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_1", "Igniter #1 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff2 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_2", "Igniter #2 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff3 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_3", "Igniter #3 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff4 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_4", "Igniter #4 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff5 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_5", "Igniter #5 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff6 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_6", "Igniter #6 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff7 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_7", "Igniter #7 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOff8 { get { return new XPlaneCommand("sim/igniters/igniter_contin_off_8", "Igniter #8 contin-ignition off."); } }
        public static XPlaneCommand IgnitersIgniterContinOn1 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_1", "Igniter #1 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn2 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_2", "Igniter #2 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn3 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_3", "Igniter #3 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn4 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_4", "Igniter #4 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn5 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_5", "Igniter #5 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn6 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_6", "Igniter #6 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn7 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_7", "Igniter #7 contin-ignition on."); } }
        public static XPlaneCommand IgnitersIgniterContinOn8 { get { return new XPlaneCommand("sim/igniters/igniter_contin_on_8", "Igniter #8 contin-ignition on."); } }
        public static XPlaneCommand StartersEngageStarter1 { get { return new XPlaneCommand("sim/starters/engage_starter_1", "Engage starter #1."); } }
        public static XPlaneCommand StartersEngageStarter2 { get { return new XPlaneCommand("sim/starters/engage_starter_2", "Engage starter #2."); } }
        public static XPlaneCommand StartersEngageStarter3 { get { return new XPlaneCommand("sim/starters/engage_starter_3", "Engage starter #3."); } }
        public static XPlaneCommand StartersEngageStarter4 { get { return new XPlaneCommand("sim/starters/engage_starter_4", "Engage starter #4."); } }
        public static XPlaneCommand StartersEngageStarter5 { get { return new XPlaneCommand("sim/starters/engage_starter_5", "Engage starter #5."); } }
        public static XPlaneCommand StartersEngageStarter6 { get { return new XPlaneCommand("sim/starters/engage_starter_6", "Engage starter #6."); } }
        public static XPlaneCommand StartersEngageStarter7 { get { return new XPlaneCommand("sim/starters/engage_starter_7", "Engage starter #7."); } }
        public static XPlaneCommand StartersEngageStarter8 { get { return new XPlaneCommand("sim/starters/engage_starter_8", "Engage starter #8."); } }
        public static XPlaneCommand EnginesThrottleDown1 { get { return new XPlaneCommand("sim/engines/throttle_down_1", "Throttle down a bit for engine #1."); } }
        public static XPlaneCommand EnginesThrottleDown2 { get { return new XPlaneCommand("sim/engines/throttle_down_2", "Throttle down a bit for engine #2."); } }
        public static XPlaneCommand EnginesThrottleDown3 { get { return new XPlaneCommand("sim/engines/throttle_down_3", "Throttle down a bit for engine #3."); } }
        public static XPlaneCommand EnginesThrottleDown4 { get { return new XPlaneCommand("sim/engines/throttle_down_4", "Throttle down a bit for engine #4."); } }
        public static XPlaneCommand EnginesThrottleDown5 { get { return new XPlaneCommand("sim/engines/throttle_down_5", "Throttle down a bit for engine #5."); } }
        public static XPlaneCommand EnginesThrottleDown6 { get { return new XPlaneCommand("sim/engines/throttle_down_6", "Throttle down a bit for engine #6."); } }
        public static XPlaneCommand EnginesThrottleDown7 { get { return new XPlaneCommand("sim/engines/throttle_down_7", "Throttle down a bit for engine #7."); } }
        public static XPlaneCommand EnginesThrottleDown8 { get { return new XPlaneCommand("sim/engines/throttle_down_8", "Throttle down a bit for engine #8."); } }
        public static XPlaneCommand EnginesThrottleUp1 { get { return new XPlaneCommand("sim/engines/throttle_up_1", "Throttle up a bit for engine #1."); } }
        public static XPlaneCommand EnginesThrottleUp2 { get { return new XPlaneCommand("sim/engines/throttle_up_2", "Throttle up a bit for engine #2."); } }
        public static XPlaneCommand EnginesThrottleUp3 { get { return new XPlaneCommand("sim/engines/throttle_up_3", "Throttle up a bit for engine #3."); } }
        public static XPlaneCommand EnginesThrottleUp4 { get { return new XPlaneCommand("sim/engines/throttle_up_4", "Throttle up a bit for engine #4."); } }
        public static XPlaneCommand EnginesThrottleUp5 { get { return new XPlaneCommand("sim/engines/throttle_up_5", "Throttle up a bit for engine #5."); } }
        public static XPlaneCommand EnginesThrottleUp6 { get { return new XPlaneCommand("sim/engines/throttle_up_6", "Throttle up a bit for engine #6."); } }
        public static XPlaneCommand EnginesThrottleUp7 { get { return new XPlaneCommand("sim/engines/throttle_up_7", "Throttle up a bit for engine #7."); } }
        public static XPlaneCommand EnginesThrottleUp8 { get { return new XPlaneCommand("sim/engines/throttle_up_8", "Throttle up a bit for engine #8."); } }
        public static XPlaneCommand EnginesPropDown1 { get { return new XPlaneCommand("sim/engines/prop_down_1", "Prop down a bit for engine #1."); } }
        public static XPlaneCommand EnginesPropDown2 { get { return new XPlaneCommand("sim/engines/prop_down_2", "Prop down a bit for engine #2."); } }
        public static XPlaneCommand EnginesPropDown3 { get { return new XPlaneCommand("sim/engines/prop_down_3", "Prop down a bit for engine #3."); } }
        public static XPlaneCommand EnginesPropDown4 { get { return new XPlaneCommand("sim/engines/prop_down_4", "Prop down a bit for engine #4."); } }
        public static XPlaneCommand EnginesPropDown5 { get { return new XPlaneCommand("sim/engines/prop_down_5", "Prop down a bit for engine #5."); } }
        public static XPlaneCommand EnginesPropDown6 { get { return new XPlaneCommand("sim/engines/prop_down_6", "Prop down a bit for engine #6."); } }
        public static XPlaneCommand EnginesPropDown7 { get { return new XPlaneCommand("sim/engines/prop_down_7", "Prop down a bit for engine #7."); } }
        public static XPlaneCommand EnginesPropDown8 { get { return new XPlaneCommand("sim/engines/prop_down_8", "Prop down a bit for engine #8."); } }
        public static XPlaneCommand EnginesPropUp1 { get { return new XPlaneCommand("sim/engines/prop_up_1", "Prop up a bit for engine #1."); } }
        public static XPlaneCommand EnginesPropUp2 { get { return new XPlaneCommand("sim/engines/prop_up_2", "Prop up a bit for engine #2."); } }
        public static XPlaneCommand EnginesPropUp3 { get { return new XPlaneCommand("sim/engines/prop_up_3", "Prop up a bit for engine #3."); } }
        public static XPlaneCommand EnginesPropUp4 { get { return new XPlaneCommand("sim/engines/prop_up_4", "Prop up a bit for engine #4."); } }
        public static XPlaneCommand EnginesPropUp5 { get { return new XPlaneCommand("sim/engines/prop_up_5", "Prop up a bit for engine #5."); } }
        public static XPlaneCommand EnginesPropUp6 { get { return new XPlaneCommand("sim/engines/prop_up_6", "Prop up a bit for engine #6."); } }
        public static XPlaneCommand EnginesPropUp7 { get { return new XPlaneCommand("sim/engines/prop_up_7", "Prop up a bit for engine #7."); } }
        public static XPlaneCommand EnginesPropUp8 { get { return new XPlaneCommand("sim/engines/prop_up_8", "Prop up a bit for engine #8."); } }
        public static XPlaneCommand EnginesMixtureDown1 { get { return new XPlaneCommand("sim/engines/mixture_down_1", "Mixture down a bit for engine #1."); } }
        public static XPlaneCommand EnginesMixtureDown2 { get { return new XPlaneCommand("sim/engines/mixture_down_2", "Mixture down a bit for engine #2."); } }
        public static XPlaneCommand EnginesMixtureDown3 { get { return new XPlaneCommand("sim/engines/mixture_down_3", "Mixture down a bit for engine #3."); } }
        public static XPlaneCommand EnginesMixtureDown4 { get { return new XPlaneCommand("sim/engines/mixture_down_4", "Mixture down a bit for engine #4."); } }
        public static XPlaneCommand EnginesMixtureDown5 { get { return new XPlaneCommand("sim/engines/mixture_down_5", "Mixture down a bit for engine #5."); } }
        public static XPlaneCommand EnginesMixtureDown6 { get { return new XPlaneCommand("sim/engines/mixture_down_6", "Mixture down a bit for engine #6."); } }
        public static XPlaneCommand EnginesMixtureDown7 { get { return new XPlaneCommand("sim/engines/mixture_down_7", "Mixture down a bit for engine #7."); } }
        public static XPlaneCommand EnginesMixtureDown8 { get { return new XPlaneCommand("sim/engines/mixture_down_8", "Mixture down a bit for engine #8."); } }
        public static XPlaneCommand EnginesMixtureUp1 { get { return new XPlaneCommand("sim/engines/mixture_up_1", "Mixture up a bit for engine #1."); } }
        public static XPlaneCommand EnginesMixtureUp2 { get { return new XPlaneCommand("sim/engines/mixture_up_2", "Mixture up a bit for engine #2."); } }
        public static XPlaneCommand EnginesMixtureUp3 { get { return new XPlaneCommand("sim/engines/mixture_up_3", "Mixture up a bit for engine #3."); } }
        public static XPlaneCommand EnginesMixtureUp4 { get { return new XPlaneCommand("sim/engines/mixture_up_4", "Mixture up a bit for engine #4."); } }
        public static XPlaneCommand EnginesMixtureUp5 { get { return new XPlaneCommand("sim/engines/mixture_up_5", "Mixture up a bit for engine #5."); } }
        public static XPlaneCommand EnginesMixtureUp6 { get { return new XPlaneCommand("sim/engines/mixture_up_6", "Mixture up a bit for engine #6."); } }
        public static XPlaneCommand EnginesMixtureUp7 { get { return new XPlaneCommand("sim/engines/mixture_up_7", "Mixture up a bit for engine #7."); } }
        public static XPlaneCommand EnginesMixtureUp8 { get { return new XPlaneCommand("sim/engines/mixture_up_8", "Mixture up a bit for engine #8."); } }
        public static XPlaneCommand EnginesBetaToggle1 { get { return new XPlaneCommand("sim/engines/beta_toggle_1", "Toggle beta prop #1."); } }
        public static XPlaneCommand EnginesBetaToggle2 { get { return new XPlaneCommand("sim/engines/beta_toggle_2", "Toggle beta prop #2."); } }
        public static XPlaneCommand EnginesBetaToggle3 { get { return new XPlaneCommand("sim/engines/beta_toggle_3", "Toggle beta prop #3."); } }
        public static XPlaneCommand EnginesBetaToggle4 { get { return new XPlaneCommand("sim/engines/beta_toggle_4", "Toggle beta prop #4."); } }
        public static XPlaneCommand EnginesBetaToggle5 { get { return new XPlaneCommand("sim/engines/beta_toggle_5", "Toggle beta prop #5."); } }
        public static XPlaneCommand EnginesBetaToggle6 { get { return new XPlaneCommand("sim/engines/beta_toggle_6", "Toggle beta prop #6."); } }
        public static XPlaneCommand EnginesBetaToggle7 { get { return new XPlaneCommand("sim/engines/beta_toggle_7", "Toggle beta prop #7."); } }
        public static XPlaneCommand EnginesBetaToggle8 { get { return new XPlaneCommand("sim/engines/beta_toggle_8", "Toggle beta prop #8."); } }
        public static XPlaneCommand EnginesThrustReverseToggle1 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_1", "Toggle thrust reversers #1."); } }
        public static XPlaneCommand EnginesThrustReverseToggle2 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_2", "Toggle thrust reversers #2."); } }
        public static XPlaneCommand EnginesThrustReverseToggle3 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_3", "Toggle thrust reversers #3."); } }
        public static XPlaneCommand EnginesThrustReverseToggle4 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_4", "Toggle thrust reversers #4."); } }
        public static XPlaneCommand EnginesThrustReverseToggle5 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_5", "Toggle thrust reversers #5."); } }
        public static XPlaneCommand EnginesThrustReverseToggle6 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_6", "Toggle thrust reversers #6."); } }
        public static XPlaneCommand EnginesThrustReverseToggle7 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_7", "Toggle thrust reversers #7."); } }
        public static XPlaneCommand EnginesThrustReverseToggle8 { get { return new XPlaneCommand("sim/engines/thrust_reverse_toggle_8", "Toggle thrust reversers #8."); } }
        public static XPlaneCommand EnginesThrustReverseHold1 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_1", "Hold thrust reverse at max #1."); } }
        public static XPlaneCommand EnginesThrustReverseHold2 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_2", "Hold thrust reverse at max #2."); } }
        public static XPlaneCommand EnginesThrustReverseHold3 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_3", "Hold thrust reverse at max #3."); } }
        public static XPlaneCommand EnginesThrustReverseHold4 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_4", "Hold thrust reverse at max #4."); } }
        public static XPlaneCommand EnginesThrustReverseHold5 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_5", "Hold thrust reverse at max #5."); } }
        public static XPlaneCommand EnginesThrustReverseHold6 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_6", "Hold thrust reverse at max #6."); } }
        public static XPlaneCommand EnginesThrustReverseHold7 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_7", "Hold thrust reverse at max #7."); } }
        public static XPlaneCommand EnginesThrustReverseHold8 { get { return new XPlaneCommand("sim/engines/thrust_reverse_hold_8", "Hold thrust reverse at max #8."); } }
        public static XPlaneCommand StartersShutDown1 { get { return new XPlaneCommand("sim/starters/shut_down_1", "Pull fuel and mags for shut-down #1."); } }
        public static XPlaneCommand StartersShutDown2 { get { return new XPlaneCommand("sim/starters/shut_down_2", "Pull fuel and mags for shut-down #2."); } }
        public static XPlaneCommand StartersShutDown3 { get { return new XPlaneCommand("sim/starters/shut_down_3", "Pull fuel and mags for shut-down #3."); } }
        public static XPlaneCommand StartersShutDown4 { get { return new XPlaneCommand("sim/starters/shut_down_4", "Pull fuel and mags for shut-down #4."); } }
        public static XPlaneCommand StartersShutDown5 { get { return new XPlaneCommand("sim/starters/shut_down_5", "Pull fuel and mags for shut-down #5."); } }
        public static XPlaneCommand StartersShutDown6 { get { return new XPlaneCommand("sim/starters/shut_down_6", "Pull fuel and mags for shut-down #6."); } }
        public static XPlaneCommand StartersShutDown7 { get { return new XPlaneCommand("sim/starters/shut_down_7", "Pull fuel and mags for shut-down #7."); } }
        public static XPlaneCommand StartersShutDown8 { get { return new XPlaneCommand("sim/starters/shut_down_8", "Pull fuel and mags for shut-down #8."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed1 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_1", "Move cowl flaps #1 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed2 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_2", "Move cowl flaps #2 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed3 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_3", "Move cowl flaps #3 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed4 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_4", "Move cowl flaps #4 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed5 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_5", "Move cowl flaps #5 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed6 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_6", "Move cowl flaps #6 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed7 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_7", "Move cowl flaps #7 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsClosed8 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_closed_8", "Move cowl flaps #8 closed a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen1 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_1", "Move cowl flaps #1 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen2 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_2", "Move cowl flaps #2 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen3 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_3", "Move cowl flaps #3 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen4 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_4", "Move cowl flaps #4 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen5 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_5", "Move cowl flaps #5 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen6 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_6", "Move cowl flaps #6 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen7 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_7", "Move cowl flaps #7 open a bit."); } }
        public static XPlaneCommand FlightControlsCowlFlapsOpen8 { get { return new XPlaneCommand("sim/flight_controls/cowl_flaps_open_8", "Move cowl flaps #8 open a bit."); } }
        public static XPlaneCommand FadecFadec1Off { get { return new XPlaneCommand("sim/fadec/fadec_1_off", "FADEC #1 off."); } }
        public static XPlaneCommand FadecFadec2Off { get { return new XPlaneCommand("sim/fadec/fadec_2_off", "FADEC #2 off."); } }
        public static XPlaneCommand FadecFadec3Off { get { return new XPlaneCommand("sim/fadec/fadec_3_off", "FADEC #3 off."); } }
        public static XPlaneCommand FadecFadec4Off { get { return new XPlaneCommand("sim/fadec/fadec_4_off", "FADEC #4 off."); } }
        public static XPlaneCommand FadecFadec5Off { get { return new XPlaneCommand("sim/fadec/fadec_5_off", "FADEC #5 off."); } }
        public static XPlaneCommand FadecFadec6Off { get { return new XPlaneCommand("sim/fadec/fadec_6_off", "FADEC #6 off."); } }
        public static XPlaneCommand FadecFadec7Off { get { return new XPlaneCommand("sim/fadec/fadec_7_off", "FADEC #7 off."); } }
        public static XPlaneCommand FadecFadec8Off { get { return new XPlaneCommand("sim/fadec/fadec_8_off", "FADEC #8 off."); } }
        public static XPlaneCommand FadecFadec1On { get { return new XPlaneCommand("sim/fadec/fadec_1_on", "FADEC #1 on."); } }
        public static XPlaneCommand FadecFadec2On { get { return new XPlaneCommand("sim/fadec/fadec_2_on", "FADEC #2 on."); } }
        public static XPlaneCommand FadecFadec3On { get { return new XPlaneCommand("sim/fadec/fadec_3_on", "FADEC #3 on."); } }
        public static XPlaneCommand FadecFadec4On { get { return new XPlaneCommand("sim/fadec/fadec_4_on", "FADEC #4 on."); } }
        public static XPlaneCommand FadecFadec5On { get { return new XPlaneCommand("sim/fadec/fadec_5_on", "FADEC #5 on."); } }
        public static XPlaneCommand FadecFadec6On { get { return new XPlaneCommand("sim/fadec/fadec_6_on", "FADEC #6 on."); } }
        public static XPlaneCommand FadecFadec7On { get { return new XPlaneCommand("sim/fadec/fadec_7_on", "FADEC #7 on."); } }
        public static XPlaneCommand FadecFadec8On { get { return new XPlaneCommand("sim/fadec/fadec_8_on", "FADEC #8 on."); } }
        public static XPlaneCommand AltairAlternateAirOff1 { get { return new XPlaneCommand("sim/altair/alternate_air_off_1", "Alternate air #1 off."); } }
        public static XPlaneCommand AltairAlternateAirOff2 { get { return new XPlaneCommand("sim/altair/alternate_air_off_2", "Alternate air #2 off."); } }
        public static XPlaneCommand AltairAlternateAirOff3 { get { return new XPlaneCommand("sim/altair/alternate_air_off_3", "Alternate air #3 off."); } }
        public static XPlaneCommand AltairAlternateAirOff4 { get { return new XPlaneCommand("sim/altair/alternate_air_off_4", "Alternate air #4 off."); } }
        public static XPlaneCommand AltairAlternateAirOff5 { get { return new XPlaneCommand("sim/altair/alternate_air_off_5", "Alternate air #5 off."); } }
        public static XPlaneCommand AltairAlternateAirOff6 { get { return new XPlaneCommand("sim/altair/alternate_air_off_6", "Alternate air #6 off."); } }
        public static XPlaneCommand AltairAlternateAirOff7 { get { return new XPlaneCommand("sim/altair/alternate_air_off_7", "Alternate air #7 off."); } }
        public static XPlaneCommand AltairAlternateAirOff8 { get { return new XPlaneCommand("sim/altair/alternate_air_off_8", "Alternate air #8 off."); } }
        public static XPlaneCommand AltairAlternateAirOn1 { get { return new XPlaneCommand("sim/altair/alternate_air_on_1", "Alternate air #1 on."); } }
        public static XPlaneCommand AltairAlternateAirOn2 { get { return new XPlaneCommand("sim/altair/alternate_air_on_2", "Alternate air #2 on."); } }
        public static XPlaneCommand AltairAlternateAirOn3 { get { return new XPlaneCommand("sim/altair/alternate_air_on_3", "Alternate air #3 on."); } }
        public static XPlaneCommand AltairAlternateAirOn4 { get { return new XPlaneCommand("sim/altair/alternate_air_on_4", "Alternate air #4 on."); } }
        public static XPlaneCommand AltairAlternateAirOn5 { get { return new XPlaneCommand("sim/altair/alternate_air_on_5", "Alternate air #5 on."); } }
        public static XPlaneCommand AltairAlternateAirOn6 { get { return new XPlaneCommand("sim/altair/alternate_air_on_6", "Alternate air #6 on."); } }
        public static XPlaneCommand AltairAlternateAirOn7 { get { return new XPlaneCommand("sim/altair/alternate_air_on_7", "Alternate air #7 on."); } }
        public static XPlaneCommand AltairAlternateAirOn8 { get { return new XPlaneCommand("sim/altair/alternate_air_on_8", "Alternate air #8 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff1 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_1", "Alternate air backup #1 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff2 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_2", "Alternate air backup #2 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff3 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_3", "Alternate air backup #3 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff4 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_4", "Alternate air backup #4 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff5 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_5", "Alternate air backup #5 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff6 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_6", "Alternate air backup #6 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff7 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_7", "Alternate air backup #7 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOff8 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_off_8", "Alternate air backup #8 off."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn1 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_1", "Alternate air backup #1 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn2 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_2", "Alternate air backup #2 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn3 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_3", "Alternate air backup #3 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn4 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_4", "Alternate air backup #4 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn5 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_5", "Alternate air backup #5 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn6 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_6", "Alternate air backup #6 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn7 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_7", "Alternate air backup #7 on."); } }
        public static XPlaneCommand AltairAlternateAirBackupOn8 { get { return new XPlaneCommand("sim/altair/alternate_air_backup_on_8", "Alternate air backup #8 on."); } }
        public static XPlaneCommand EnginesFireExt1Off { get { return new XPlaneCommand("sim/engines/fire_ext_1_off", "Fire extinguisher #1 off."); } }
        public static XPlaneCommand EnginesFireExt2Off { get { return new XPlaneCommand("sim/engines/fire_ext_2_off", "Fire extinguisher #2 off."); } }
        public static XPlaneCommand EnginesFireExt3Off { get { return new XPlaneCommand("sim/engines/fire_ext_3_off", "Fire extinguisher #3 off."); } }
        public static XPlaneCommand EnginesFireExt4Off { get { return new XPlaneCommand("sim/engines/fire_ext_4_off", "Fire extinguisher #4 off."); } }
        public static XPlaneCommand EnginesFireExt5Off { get { return new XPlaneCommand("sim/engines/fire_ext_5_off", "Fire extinguisher #5 off."); } }
        public static XPlaneCommand EnginesFireExt6Off { get { return new XPlaneCommand("sim/engines/fire_ext_6_off", "Fire extinguisher #6 off."); } }
        public static XPlaneCommand EnginesFireExt7Off { get { return new XPlaneCommand("sim/engines/fire_ext_7_off", "Fire extinguisher #7 off."); } }
        public static XPlaneCommand EnginesFireExt8Off { get { return new XPlaneCommand("sim/engines/fire_ext_8_off", "Fire extinguisher #8 off."); } }
        public static XPlaneCommand EnginesFireExt1On { get { return new XPlaneCommand("sim/engines/fire_ext_1_on", "Fire extinguisher #1 on."); } }
        public static XPlaneCommand EnginesFireExt2On { get { return new XPlaneCommand("sim/engines/fire_ext_2_on", "Fire extinguisher #2 on."); } }
        public static XPlaneCommand EnginesFireExt3On { get { return new XPlaneCommand("sim/engines/fire_ext_3_on", "Fire extinguisher #3 on."); } }
        public static XPlaneCommand EnginesFireExt4On { get { return new XPlaneCommand("sim/engines/fire_ext_4_on", "Fire extinguisher #4 on."); } }
        public static XPlaneCommand EnginesFireExt5On { get { return new XPlaneCommand("sim/engines/fire_ext_5_on", "Fire extinguisher #5 on."); } }
        public static XPlaneCommand EnginesFireExt6On { get { return new XPlaneCommand("sim/engines/fire_ext_6_on", "Fire extinguisher #6 on."); } }
        public static XPlaneCommand EnginesFireExt7On { get { return new XPlaneCommand("sim/engines/fire_ext_7_on", "Fire extinguisher #7 on."); } }
        public static XPlaneCommand EnginesFireExt8On { get { return new XPlaneCommand("sim/engines/fire_ext_8_on", "Fire extinguisher #8 on."); } }
        public static XPlaneCommand FlightControlsFlapsUp { get { return new XPlaneCommand("sim/flight_controls/flaps_up", "Flaps up a notch."); } }
        public static XPlaneCommand FlightControlsFlapsDown { get { return new XPlaneCommand("sim/flight_controls/flaps_down", "Flaps down a notch."); } }
        public static XPlaneCommand FlightControlsVectorSweepAft { get { return new XPlaneCommand("sim/flight_controls/vector_sweep_aft", "Vector or sweep aft."); } }
        public static XPlaneCommand FlightControlsVectorSweepForward { get { return new XPlaneCommand("sim/flight_controls/vector_sweep_forward", "Vector or sweep forward."); } }
        public static XPlaneCommand FlightControlsBlimpLiftDown { get { return new XPlaneCommand("sim/flight_controls/blimp_lift_down", "Blimp lift down a bit."); } }
        public static XPlaneCommand FlightControlsBlimpLiftUp { get { return new XPlaneCommand("sim/flight_controls/blimp_lift_up", "Blimp lift up a bit."); } }
        public static XPlaneCommand FlightControlsSpeedBrakesDownOne { get { return new XPlaneCommand("sim/flight_controls/speed_brakes_down_one", "Speedbrakes extend one."); } }
        public static XPlaneCommand FlightControlsSpeedBrakesUpOne { get { return new XPlaneCommand("sim/flight_controls/speed_brakes_up_one", "Speedbrakes retract one."); } }
        public static XPlaneCommand FlightControlsSpeedBrakesDownAll { get { return new XPlaneCommand("sim/flight_controls/speed_brakes_down_all", "Speedbrakes extend full."); } }
        public static XPlaneCommand FlightControlsSpeedBrakesUpAll { get { return new XPlaneCommand("sim/flight_controls/speed_brakes_up_all", "Speedbrakes retract full."); } }
        public static XPlaneCommand FlightControlsSpeedBrakesToggle { get { return new XPlaneCommand("sim/flight_controls/speed_brakes_toggle", "Speedbrakes toggle."); } }
        public static XPlaneCommand FlightControlsLandingGearDown { get { return new XPlaneCommand("sim/flight_controls/landing_gear_down", "Landing gear down."); } }
        public static XPlaneCommand FlightControlsLandingGearUp { get { return new XPlaneCommand("sim/flight_controls/landing_gear_up", "Landing gear up."); } }
        public static XPlaneCommand FlightControlsLandingGearToggle { get { return new XPlaneCommand("sim/flight_controls/landing_gear_toggle", "Landing gear toggle."); } }
        public static XPlaneCommand FlightControlsLandingGearEmerOn { get { return new XPlaneCommand("sim/flight_controls/landing_gear_emer_on", "Landing gear emergency override down."); } }
        public static XPlaneCommand FlightControlsLandingGearEmerOff { get { return new XPlaneCommand("sim/flight_controls/landing_gear_emer_off", "Landing gear emergency override off."); } }
        public static XPlaneCommand FlightControlsNwheelSteerToggle { get { return new XPlaneCommand("sim/flight_controls/nwheel_steer_toggle", "Nosewheel steer toggle."); } }
        public static XPlaneCommand FlightControlsTailWheelLockToggle { get { return new XPlaneCommand("sim/flight_controls/tail_wheel_lock_toggle", "Toggle tailwheel lock."); } }
        public static XPlaneCommand FlightControlsTailWheelLockEngage { get { return new XPlaneCommand("sim/flight_controls/tail_wheel_lock_engage", "Engage tailwheel lock."); } }
        public static XPlaneCommand FlightControlsWaterRudderDown { get { return new XPlaneCommand("sim/flight_controls/water_rudder_down", "Water rudder down (engage)."); } }
        public static XPlaneCommand FlightControlsWaterRudderUp { get { return new XPlaneCommand("sim/flight_controls/water_rudder_up", "Water rudder up (disengage)."); } }
        public static XPlaneCommand FlightControlsWaterRudderToggle { get { return new XPlaneCommand("sim/flight_controls/water_rudder_toggle", "Toggle water rudder."); } }
        public static XPlaneCommand FlightControlsLeftBrake { get { return new XPlaneCommand("sim/flight_controls/left_brake", "Hold brake left."); } }
        public static XPlaneCommand FlightControlsRightBrake { get { return new XPlaneCommand("sim/flight_controls/right_brake", "Hold brake right."); } }
        public static XPlaneCommand FlightControlsBrakesToggleRegular { get { return new XPlaneCommand("sim/flight_controls/brakes_toggle_regular", "Toggle brakes regular effort."); } }
        public static XPlaneCommand FlightControlsBrakesToggleMax { get { return new XPlaneCommand("sim/flight_controls/brakes_toggle_max", "Toggle brakes max effort."); } }
        public static XPlaneCommand FlightControlsBrakesRegular { get { return new XPlaneCommand("sim/flight_controls/brakes_regular", "Hold brakes regular."); } }
        public static XPlaneCommand FlightControlsBrakesMax { get { return new XPlaneCommand("sim/flight_controls/brakes_max", "Hold brakes maximum."); } }
        public static XPlaneCommand FlightControlsBrakesToggleAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_toggle_auto", "Toggle auto-brakes."); } }
        public static XPlaneCommand FlightControlsBrakesDnAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_dn_auto", "Auto-brakes down."); } }
        public static XPlaneCommand FlightControlsBrakesUpAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_up_auto", "Auto-brakes up."); } }
        public static XPlaneCommand FlightControlsBrakesOffAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_off_auto", "Auto-brakes off/disarm."); } }
        public static XPlaneCommand FlightControlsBrakesRtoAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_rto_auto", "Auto-brakes RTO."); } }
        public static XPlaneCommand FlightControlsBrakes1Auto { get { return new XPlaneCommand("sim/flight_controls/brakes_1_auto", "Auto-brakes 1."); } }
        public static XPlaneCommand FlightControlsBrakes2Auto { get { return new XPlaneCommand("sim/flight_controls/brakes_2_auto", "Auto-brakes 2."); } }
        public static XPlaneCommand FlightControlsBrakes3Auto { get { return new XPlaneCommand("sim/flight_controls/brakes_3_auto", "Auto-brakes 3."); } }
        public static XPlaneCommand FlightControlsBrakesMaxAuto { get { return new XPlaneCommand("sim/flight_controls/brakes_max_auto", "Auto-brakes max."); } }
        public static XPlaneCommand SystemsYawDamperOn { get { return new XPlaneCommand("sim/systems/yaw_damper_on", "Yaw damper on."); } }
        public static XPlaneCommand SystemsYawDamperOff { get { return new XPlaneCommand("sim/systems/yaw_damper_off", "Yaw damper off."); } }
        public static XPlaneCommand SystemsYawDamperToggle { get { return new XPlaneCommand("sim/systems/yaw_damper_toggle", "Toggle yaw damper."); } }
        public static XPlaneCommand SystemsPropSyncOn { get { return new XPlaneCommand("sim/systems/prop_sync_on", "Prop sync on."); } }
        public static XPlaneCommand SystemsPropSyncOff { get { return new XPlaneCommand("sim/systems/prop_sync_off", "Prop sync off."); } }
        public static XPlaneCommand SystemsPropSyncToggle { get { return new XPlaneCommand("sim/systems/prop_sync_toggle", "Prop sync toggle."); } }
        public static XPlaneCommand SystemsFeatherModeDown { get { return new XPlaneCommand("sim/systems/feather_mode_down", "Auto-feather mode down."); } }
        public static XPlaneCommand SystemsFeatherModeUp { get { return new XPlaneCommand("sim/systems/feather_mode_up", "Auto-feather mode up."); } }
        public static XPlaneCommand SystemsFeatherModeOff { get { return new XPlaneCommand("sim/systems/feather_mode_off", "Auto-feather off."); } }
        public static XPlaneCommand SystemsFeatherModeArm { get { return new XPlaneCommand("sim/systems/feather_mode_arm", "Auto-feather on."); } }
        public static XPlaneCommand SystemsFeatherModeTest { get { return new XPlaneCommand("sim/systems/feather_mode_test", "Auto-feather test."); } }
        public static XPlaneCommand FlightControlsHydraulicOn { get { return new XPlaneCommand("sim/flight_controls/hydraulic_on", "Engine-driven hydraulic pumps on"); } }
        public static XPlaneCommand FlightControlsHydraulicOff { get { return new XPlaneCommand("sim/flight_controls/hydraulic_off", "Engine-driven hydraulic pumps off"); } }
        public static XPlaneCommand FlightControlsHydraulicTog { get { return new XPlaneCommand("sim/flight_controls/hydraulic_tog", "Engine-driven hydraulic pumps tog"); } }
        public static XPlaneCommand FlightControlsTailhookDown { get { return new XPlaneCommand("sim/flight_controls/tailhook_down", "Tailhook down."); } }
        public static XPlaneCommand FlightControlsTailhookUp { get { return new XPlaneCommand("sim/flight_controls/tailhook_up", "Tailhook up."); } }
        public static XPlaneCommand FlightControlsTailhookToggle { get { return new XPlaneCommand("sim/flight_controls/tailhook_toggle", "Toggle the tailhook."); } }
        public static XPlaneCommand FlightControlsCanopyOpen { get { return new XPlaneCommand("sim/flight_controls/canopy_open", "Canopy open."); } }
        public static XPlaneCommand FlightControlsCanopyClose { get { return new XPlaneCommand("sim/flight_controls/canopy_close", "Canopy close."); } }
        public static XPlaneCommand FlightControlsCanopyToggle { get { return new XPlaneCommand("sim/flight_controls/canopy_toggle", "Canopy toggle."); } }
        public static XPlaneCommand FlightControlsRotorBrakeToggle { get { return new XPlaneCommand("sim/flight_controls/rotor_brake_toggle", "Toggle rotor brake."); } }
        public static XPlaneCommand FlightControlsHotelModeToggle { get { return new XPlaneCommand("sim/flight_controls/hotel_mode_toggle", "Toggle hotel mode."); } }
        public static XPlaneCommand SystemsArtificialStabilityToggle { get { return new XPlaneCommand("sim/systems/artificial_stability_toggle", "Toggle artificial stability power."); } }
        public static XPlaneCommand FlightControlsPuffersToggle { get { return new XPlaneCommand("sim/flight_controls/puffers_toggle", "Toggle puffers."); } }
        public static XPlaneCommand EnginesRocketsUp { get { return new XPlaneCommand("sim/engines/rockets_up", "Orbital maneuver rockets up."); } }
        public static XPlaneCommand EnginesRocketsDown { get { return new XPlaneCommand("sim/engines/rockets_down", "Orbital maneuver rockets down."); } }
        public static XPlaneCommand EnginesRocketsLeft { get { return new XPlaneCommand("sim/engines/rockets_left", "Orbital maneuver rockets left."); } }
        public static XPlaneCommand EnginesRocketsRight { get { return new XPlaneCommand("sim/engines/rockets_right", "Orbital maneuver rockets right."); } }
        public static XPlaneCommand EnginesRocketsForward { get { return new XPlaneCommand("sim/engines/rockets_forward", "Orbital maneuver rockets fore."); } }
        public static XPlaneCommand EnginesRocketsAft { get { return new XPlaneCommand("sim/engines/rockets_aft", "Orbital maneuver rockets aft."); } }
        public static XPlaneCommand FuelFuelTankSelectorLftOne { get { return new XPlaneCommand("sim/fuel/fuel_tank_selector_lft_one", "Select fuel tank left one."); } }
        public static XPlaneCommand FuelFuelTankSelectorRgtOne { get { return new XPlaneCommand("sim/fuel/fuel_tank_selector_rgt_one", "Select fuel tank right one."); } }
        public static XPlaneCommand FuelFuelTankPump1On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_1_on", "Fuel pump for tank #1 on."); } }
        public static XPlaneCommand FuelFuelTankPump2On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_2_on", "Fuel pump for tank #2 on."); } }
        public static XPlaneCommand FuelFuelTankPump3On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_3_on", "Fuel pump for tank #3 on."); } }
        public static XPlaneCommand FuelFuelTankPump4On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_4_on", "Fuel pump for tank #4 on."); } }
        public static XPlaneCommand FuelFuelTankPump5On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_5_on", "Fuel pump for tank #5 on."); } }
        public static XPlaneCommand FuelFuelTankPump6On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_6_on", "Fuel pump for tank #6 on."); } }
        public static XPlaneCommand FuelFuelTankPump7On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_7_on", "Fuel pump for tank #7 on."); } }
        public static XPlaneCommand FuelFuelTankPump8On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_8_on", "Fuel pump for tank #8 on."); } }
        public static XPlaneCommand FuelFuelTankPump9On { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_9_on", "Fuel pump for tank #9 on."); } }
        public static XPlaneCommand FuelFuelTankPump1Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_1_off", "Fuel pump for tank #1 off."); } }
        public static XPlaneCommand FuelFuelTankPump2Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_2_off", "Fuel pump for tank #2 off."); } }
        public static XPlaneCommand FuelFuelTankPump3Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_3_off", "Fuel pump for tank #3 off."); } }
        public static XPlaneCommand FuelFuelTankPump4Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_4_off", "Fuel pump for tank #4 off."); } }
        public static XPlaneCommand FuelFuelTankPump5Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_5_off", "Fuel pump for tank #5 off."); } }
        public static XPlaneCommand FuelFuelTankPump6Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_6_off", "Fuel pump for tank #6 off."); } }
        public static XPlaneCommand FuelFuelTankPump7Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_7_off", "Fuel pump for tank #7 off."); } }
        public static XPlaneCommand FuelFuelTankPump8Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_8_off", "Fuel pump for tank #8 off."); } }
        public static XPlaneCommand FuelFuelTankPump9Off { get { return new XPlaneCommand("sim/fuel/fuel_tank_pump_9_off", "Fuel pump for tank #9 off."); } }
        public static XPlaneCommand FuelFuelSelectorNone { get { return new XPlaneCommand("sim/fuel/fuel_selector_none", "Set fuel selector to none (shut off)."); } }
        public static XPlaneCommand FuelFuelSelectorLft { get { return new XPlaneCommand("sim/fuel/fuel_selector_lft", "Set fuel selector to left tanks."); } }
        public static XPlaneCommand FuelFuelSelectorCtr { get { return new XPlaneCommand("sim/fuel/fuel_selector_ctr", "Set fuel selector to center tanks."); } }
        public static XPlaneCommand FuelFuelSelectorRgt { get { return new XPlaneCommand("sim/fuel/fuel_selector_rgt", "Set fuel selector to right tanks."); } }
        public static XPlaneCommand FuelFuelSelectorAll { get { return new XPlaneCommand("sim/fuel/fuel_selector_all", "Set fuel selector to all tanks."); } }
        public static XPlaneCommand FuelLeftFuelSelectorNone { get { return new XPlaneCommand("sim/fuel/left_fuel_selector_none", "Set fuel selector for left engine to none (shut off)."); } }
        public static XPlaneCommand FuelLeftFuelSelectorLft { get { return new XPlaneCommand("sim/fuel/left_fuel_selector_lft", "Set fuel selector for left engine to left tanks."); } }
        public static XPlaneCommand FuelLeftFuelSelectorCtr { get { return new XPlaneCommand("sim/fuel/left_fuel_selector_ctr", "Set fuel selector for left engine to center tanks."); } }
        public static XPlaneCommand FuelLeftFuelSelectorRgt { get { return new XPlaneCommand("sim/fuel/left_fuel_selector_rgt", "Set fuel selector for left engine to right tanks."); } }
        public static XPlaneCommand FuelLeftFuelSelectorAll { get { return new XPlaneCommand("sim/fuel/left_fuel_selector_all", "Set fuel selector for left engine to all tanks."); } }
        public static XPlaneCommand FuelRightFuelSelectorNone { get { return new XPlaneCommand("sim/fuel/right_fuel_selector_none", "Set fuel selector for right engine to none (shut off)."); } }
        public static XPlaneCommand FuelRightFuelSelectorLft { get { return new XPlaneCommand("sim/fuel/right_fuel_selector_lft", "Set fuel selector for right engine to left tanks."); } }
        public static XPlaneCommand FuelRightFuelSelectorCtr { get { return new XPlaneCommand("sim/fuel/right_fuel_selector_ctr", "Set fuel selector for right engine to center tanks."); } }
        public static XPlaneCommand FuelRightFuelSelectorRgt { get { return new XPlaneCommand("sim/fuel/right_fuel_selector_rgt", "Set fuel selector for right engine to right tanks."); } }
        public static XPlaneCommand FuelRightFuelSelectorAll { get { return new XPlaneCommand("sim/fuel/right_fuel_selector_all", "Set fuel selector for right engine to all tanks."); } }
        public static XPlaneCommand FuelFuelTransferToLft { get { return new XPlaneCommand("sim/fuel/fuel_transfer_to_lft", "Transfer fuel to left."); } }
        public static XPlaneCommand FuelFuelTransferToCtr { get { return new XPlaneCommand("sim/fuel/fuel_transfer_to_ctr", "Transfer fuel to center."); } }
        public static XPlaneCommand FuelFuelTransferToRgt { get { return new XPlaneCommand("sim/fuel/fuel_transfer_to_rgt", "Transfer fuel to right."); } }
        public static XPlaneCommand FuelFuelTransferToAft { get { return new XPlaneCommand("sim/fuel/fuel_transfer_to_aft", "Transfer fuel to aft."); } }
        public static XPlaneCommand FuelFuelTransferToOff { get { return new XPlaneCommand("sim/fuel/fuel_transfer_to_off", "Transfer fuel to none."); } }
        public static XPlaneCommand FuelFuelTransferFromLft { get { return new XPlaneCommand("sim/fuel/fuel_transfer_from_lft", "Transfer fuel from left."); } }
        public static XPlaneCommand FuelFuelTransferFromCtr { get { return new XPlaneCommand("sim/fuel/fuel_transfer_from_ctr", "Transfer fuel from center."); } }
        public static XPlaneCommand FuelFuelTransferFromRgt { get { return new XPlaneCommand("sim/fuel/fuel_transfer_from_rgt", "Transfer fuel from right."); } }
        public static XPlaneCommand FuelFuelTransferFromAft { get { return new XPlaneCommand("sim/fuel/fuel_transfer_from_aft", "Transfer fuel from aft."); } }
        public static XPlaneCommand FuelFuelTransferFromOff { get { return new XPlaneCommand("sim/fuel/fuel_transfer_from_off", "Transfer fuel from none."); } }
        public static XPlaneCommand FuelFuelCrossfeedFromLftTank { get { return new XPlaneCommand("sim/fuel/fuel_crossfeed_from_lft_tank", "Cross-feed fuel from left tank."); } }
        public static XPlaneCommand FuelFuelCrossfeedOff { get { return new XPlaneCommand("sim/fuel/fuel_crossfeed_off", "Cross-feed fuel off."); } }
        public static XPlaneCommand FuelFuelCrossfeedFromRgtTank { get { return new XPlaneCommand("sim/fuel/fuel_crossfeed_from_rgt_tank", "Cross-feed fuel from right tank."); } }
        public static XPlaneCommand FuelFuelFirewallValveLftOpen { get { return new XPlaneCommand("sim/fuel/fuel_firewall_valve_lft_open", "Firewall fuel valve left open."); } }
        public static XPlaneCommand FuelFuelFirewallValveLftClosed { get { return new XPlaneCommand("sim/fuel/fuel_firewall_valve_lft_closed", "Firewall fuel valve left closed."); } }
        public static XPlaneCommand FuelFuelFirewallValveRgtOpen { get { return new XPlaneCommand("sim/fuel/fuel_firewall_valve_rgt_open", "Firewall fuel valve right open."); } }
        public static XPlaneCommand FuelFuelFirewallValveRgtClosed { get { return new XPlaneCommand("sim/fuel/fuel_firewall_valve_rgt_closed", "Firewall fuel valve right closed."); } }
        public static XPlaneCommand FuelLeftXferOverride { get { return new XPlaneCommand("sim/fuel/left_xfer_override", "Aux to feeder transfer left override."); } }
        public static XPlaneCommand FuelLeftXferOn { get { return new XPlaneCommand("sim/fuel/left_xfer_on", "Aux to feeder transfer left on."); } }
        public static XPlaneCommand FuelLeftXferOff { get { return new XPlaneCommand("sim/fuel/left_xfer_off", "Aux to feeder transfer left off."); } }
        public static XPlaneCommand FuelLeftXferUp { get { return new XPlaneCommand("sim/fuel/left_xfer_up", "Aux to feeder transfer left off->on->overide."); } }
        public static XPlaneCommand FuelLeftXferDn { get { return new XPlaneCommand("sim/fuel/left_xfer_dn", "Aux to feeder transfer left override->on->off."); } }
        public static XPlaneCommand FuelRightXferOverride { get { return new XPlaneCommand("sim/fuel/right_xfer_override", "Aux to feeder transfer right override."); } }
        public static XPlaneCommand FuelRightXferOn { get { return new XPlaneCommand("sim/fuel/right_xfer_on", "Aux to feeder transfer right on."); } }
        public static XPlaneCommand FuelRightXferOff { get { return new XPlaneCommand("sim/fuel/right_xfer_off", "Aux to feeder transfer right off."); } }
        public static XPlaneCommand FuelRightXferUp { get { return new XPlaneCommand("sim/fuel/right_xfer_up", "Aux to feeder transfer right off->on->overide."); } }
        public static XPlaneCommand FuelRightXferDn { get { return new XPlaneCommand("sim/fuel/right_xfer_dn", "Aux to feeder transfer right override->on->off."); } }
        public static XPlaneCommand FuelLeftXferTest { get { return new XPlaneCommand("sim/fuel/left_xfer_test", "Aux to feeder transfer test left."); } }
        public static XPlaneCommand FuelRightXferTest { get { return new XPlaneCommand("sim/fuel/right_xfer_test", "Aux to feeder transfer test right."); } }
        public static XPlaneCommand FuelAutoCrossfeedOnOpen { get { return new XPlaneCommand("sim/fuel/auto_crossfeed_on_open", "Crossfeed valve open."); } }
        public static XPlaneCommand FuelAutoCrossfeedAuto { get { return new XPlaneCommand("sim/fuel/auto_crossfeed_auto", "Open crossfeed valve when pressure difference detected."); } }
        public static XPlaneCommand FuelAutoCrossfeedOff { get { return new XPlaneCommand("sim/fuel/auto_crossfeed_off", "Close crossfeed valve and turn off auto-crossfeed."); } }
        public static XPlaneCommand FuelAutoCrossfeedUp { get { return new XPlaneCommand("sim/fuel/auto_crossfeed_up", "Auto-crossfeed off->auto->on."); } }
        public static XPlaneCommand FuelAutoCrossfeedDown { get { return new XPlaneCommand("sim/fuel/auto_crossfeed_down", "Auto-crossfeed on->auto->off."); } }
        public static XPlaneCommand FuelFuelPumpsOn { get { return new XPlaneCommand("sim/fuel/fuel_pumps_on", "Fuel pumps on."); } }
        public static XPlaneCommand FuelFuelPumpsOff { get { return new XPlaneCommand("sim/fuel/fuel_pumps_off", "Fuel pumps off."); } }
        public static XPlaneCommand FuelFuelPumpsTog { get { return new XPlaneCommand("sim/fuel/fuel_pumps_tog", "Fuel pumps toggle."); } }
        public static XPlaneCommand FuelFuelPump1On { get { return new XPlaneCommand("sim/fuel/fuel_pump_1_on", "Fuel pump for engine #1 on."); } }
        public static XPlaneCommand FuelFuelPump2On { get { return new XPlaneCommand("sim/fuel/fuel_pump_2_on", "Fuel pump for engine #2 on."); } }
        public static XPlaneCommand FuelFuelPump3On { get { return new XPlaneCommand("sim/fuel/fuel_pump_3_on", "Fuel pump for engine #3 on."); } }
        public static XPlaneCommand FuelFuelPump4On { get { return new XPlaneCommand("sim/fuel/fuel_pump_4_on", "Fuel pump for engine #4 on."); } }
        public static XPlaneCommand FuelFuelPump5On { get { return new XPlaneCommand("sim/fuel/fuel_pump_5_on", "Fuel pump for engine #5 on."); } }
        public static XPlaneCommand FuelFuelPump6On { get { return new XPlaneCommand("sim/fuel/fuel_pump_6_on", "Fuel pump for engine #6 on."); } }
        public static XPlaneCommand FuelFuelPump7On { get { return new XPlaneCommand("sim/fuel/fuel_pump_7_on", "Fuel pump for engine #7 on."); } }
        public static XPlaneCommand FuelFuelPump8On { get { return new XPlaneCommand("sim/fuel/fuel_pump_8_on", "Fuel pump for engine #8 on."); } }
        public static XPlaneCommand FuelFuelPump1Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_1_off", "Fuel pump for engine #1 off."); } }
        public static XPlaneCommand FuelFuelPump2Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_2_off", "Fuel pump for engine #2 off."); } }
        public static XPlaneCommand FuelFuelPump3Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_3_off", "Fuel pump for engine #3 off."); } }
        public static XPlaneCommand FuelFuelPump4Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_4_off", "Fuel pump for engine #4 off."); } }
        public static XPlaneCommand FuelFuelPump5Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_5_off", "Fuel pump for engine #5 off."); } }
        public static XPlaneCommand FuelFuelPump6Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_6_off", "Fuel pump for engine #6 off."); } }
        public static XPlaneCommand FuelFuelPump7Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_7_off", "Fuel pump for engine #7 off."); } }
        public static XPlaneCommand FuelFuelPump8Off { get { return new XPlaneCommand("sim/fuel/fuel_pump_8_off", "Fuel pump for engine #8 off."); } }
        public static XPlaneCommand FuelFuelPump1Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_1_tog", "Fuel pump for engine #1 toggle."); } }
        public static XPlaneCommand FuelFuelPump2Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_2_tog", "Fuel pump for engine #2 toggle."); } }
        public static XPlaneCommand FuelFuelPump3Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_3_tog", "Fuel pump for engine #3 toggle."); } }
        public static XPlaneCommand FuelFuelPump4Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_4_tog", "Fuel pump for engine #4 toggle."); } }
        public static XPlaneCommand FuelFuelPump5Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_5_tog", "Fuel pump for engine #5 toggle."); } }
        public static XPlaneCommand FuelFuelPump6Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_6_tog", "Fuel pump for engine #6 toggle."); } }
        public static XPlaneCommand FuelFuelPump7Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_7_tog", "Fuel pump for engine #7 toggle."); } }
        public static XPlaneCommand FuelFuelPump8Tog { get { return new XPlaneCommand("sim/fuel/fuel_pump_8_tog", "Fuel pump for engine #8 toggle."); } }
        public static XPlaneCommand FuelFuelPump1Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_1_prime", "Fuel pump prime for engine #1 on."); } }
        public static XPlaneCommand FuelFuelPump2Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_2_prime", "Fuel pump prime for engine #2 on."); } }
        public static XPlaneCommand FuelFuelPump3Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_3_prime", "Fuel pump prime for engine #3 on."); } }
        public static XPlaneCommand FuelFuelPump4Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_4_prime", "Fuel pump prime for engine #4 on."); } }
        public static XPlaneCommand FuelFuelPump5Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_5_prime", "Fuel pump prime for engine #5 on."); } }
        public static XPlaneCommand FuelFuelPump6Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_6_prime", "Fuel pump prime for engine #6 on."); } }
        public static XPlaneCommand FuelFuelPump7Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_7_prime", "Fuel pump prime for engine #7 on."); } }
        public static XPlaneCommand FuelFuelPump8Prime { get { return new XPlaneCommand("sim/fuel/fuel_pump_8_prime", "Fuel pump prime for engine #8 on."); } }
        public static XPlaneCommand ElectricalCrossTieOn { get { return new XPlaneCommand("sim/electrical/cross_tie_on", "Cross-tie on."); } }
        public static XPlaneCommand ElectricalCrossTieOff { get { return new XPlaneCommand("sim/electrical/cross_tie_off", "Cross-tie off."); } }
        public static XPlaneCommand ElectricalCrossTieToggle { get { return new XPlaneCommand("sim/electrical/cross_tie_toggle", "Cross-tie toggle."); } }
        public static XPlaneCommand ElectricalInvertersOn { get { return new XPlaneCommand("sim/electrical/inverters_on", "Inverters on."); } }
        public static XPlaneCommand ElectricalInvertersOff { get { return new XPlaneCommand("sim/electrical/inverters_off", "Inverters off."); } }
        public static XPlaneCommand ElectricalInvertersToggle { get { return new XPlaneCommand("sim/electrical/inverters_toggle", "Inverters toggle."); } }
        public static XPlaneCommand ElectricalInverter1On { get { return new XPlaneCommand("sim/electrical/inverter_1_on", "Inverter 1 on."); } }
        public static XPlaneCommand ElectricalInverter1Off { get { return new XPlaneCommand("sim/electrical/inverter_1_off", "Inverter 1 off."); } }
        public static XPlaneCommand ElectricalInverter1Toggle { get { return new XPlaneCommand("sim/electrical/inverter_1_toggle", "Inverter 1 toggle."); } }
        public static XPlaneCommand ElectricalInverter2On { get { return new XPlaneCommand("sim/electrical/inverter_2_on", "Inverter 2 on."); } }
        public static XPlaneCommand ElectricalInverter2Off { get { return new XPlaneCommand("sim/electrical/inverter_2_off", "Inverter 2 off."); } }
        public static XPlaneCommand ElectricalInverter2Toggle { get { return new XPlaneCommand("sim/electrical/inverter_2_toggle", "Inverter 2 toggle."); } }
        public static XPlaneCommand ElectricalBatteriesToggle { get { return new XPlaneCommand("sim/electrical/batteries_toggle", "Batteries all toggle."); } }
        public static XPlaneCommand ElectricalBattery1On { get { return new XPlaneCommand("sim/electrical/battery_1_on", "Battery 1 on."); } }
        public static XPlaneCommand ElectricalBattery2On { get { return new XPlaneCommand("sim/electrical/battery_2_on", "Battery 2 on."); } }
        public static XPlaneCommand ElectricalBattery1Off { get { return new XPlaneCommand("sim/electrical/battery_1_off", "Battery 1 off."); } }
        public static XPlaneCommand ElectricalBattery2Off { get { return new XPlaneCommand("sim/electrical/battery_2_off", "Battery 2 off."); } }
        public static XPlaneCommand ElectricalBattery1Toggle { get { return new XPlaneCommand("sim/electrical/battery_1_toggle", "Battery 1 toggle."); } }
        public static XPlaneCommand ElectricalBattery2Toggle { get { return new XPlaneCommand("sim/electrical/battery_2_toggle", "Battery 2 toggle."); } }
        public static XPlaneCommand ElectricalGeneratorsToggle { get { return new XPlaneCommand("sim/electrical/generators_toggle", "Generators all toggle."); } }
        public static XPlaneCommand ElectricalGenerator1Off { get { return new XPlaneCommand("sim/electrical/generator_1_off", "Generator #1 off."); } }
        public static XPlaneCommand ElectricalGenerator2Off { get { return new XPlaneCommand("sim/electrical/generator_2_off", "Generator #2 off."); } }
        public static XPlaneCommand ElectricalGenerator3Off { get { return new XPlaneCommand("sim/electrical/generator_3_off", "Generator #3 off."); } }
        public static XPlaneCommand ElectricalGenerator4Off { get { return new XPlaneCommand("sim/electrical/generator_4_off", "Generator #4 off."); } }
        public static XPlaneCommand ElectricalGenerator5Off { get { return new XPlaneCommand("sim/electrical/generator_5_off", "Generator #5 off."); } }
        public static XPlaneCommand ElectricalGenerator6Off { get { return new XPlaneCommand("sim/electrical/generator_6_off", "Generator #6 off."); } }
        public static XPlaneCommand ElectricalGenerator7Off { get { return new XPlaneCommand("sim/electrical/generator_7_off", "Generator #7 off."); } }
        public static XPlaneCommand ElectricalGenerator8Off { get { return new XPlaneCommand("sim/electrical/generator_8_off", "Generator #8 off."); } }
        public static XPlaneCommand ElectricalGenerator1On { get { return new XPlaneCommand("sim/electrical/generator_1_on", "Generator #1 on."); } }
        public static XPlaneCommand ElectricalGenerator2On { get { return new XPlaneCommand("sim/electrical/generator_2_on", "Generator #2 on."); } }
        public static XPlaneCommand ElectricalGenerator3On { get { return new XPlaneCommand("sim/electrical/generator_3_on", "Generator #3 on."); } }
        public static XPlaneCommand ElectricalGenerator4On { get { return new XPlaneCommand("sim/electrical/generator_4_on", "Generator #4 on."); } }
        public static XPlaneCommand ElectricalGenerator5On { get { return new XPlaneCommand("sim/electrical/generator_5_on", "Generator #5 on."); } }
        public static XPlaneCommand ElectricalGenerator6On { get { return new XPlaneCommand("sim/electrical/generator_6_on", "Generator #6 on."); } }
        public static XPlaneCommand ElectricalGenerator7On { get { return new XPlaneCommand("sim/electrical/generator_7_on", "Generator #7 on."); } }
        public static XPlaneCommand ElectricalGenerator8On { get { return new XPlaneCommand("sim/electrical/generator_8_on", "Generator #8 on."); } }
        public static XPlaneCommand ElectricalGenerator1Toggle { get { return new XPlaneCommand("sim/electrical/generator_1_toggle", "Generator #1 toggle."); } }
        public static XPlaneCommand ElectricalGenerator2Toggle { get { return new XPlaneCommand("sim/electrical/generator_2_toggle", "Generator #2 toggle."); } }
        public static XPlaneCommand ElectricalGenerator3Toggle { get { return new XPlaneCommand("sim/electrical/generator_3_toggle", "Generator #3 toggle."); } }
        public static XPlaneCommand ElectricalGenerator4Toggle { get { return new XPlaneCommand("sim/electrical/generator_4_toggle", "Generator #4 toggle."); } }
        public static XPlaneCommand ElectricalGenerator5Toggle { get { return new XPlaneCommand("sim/electrical/generator_5_toggle", "Generator #5 toggle."); } }
        public static XPlaneCommand ElectricalGenerator6Toggle { get { return new XPlaneCommand("sim/electrical/generator_6_toggle", "Generator #6 toggle."); } }
        public static XPlaneCommand ElectricalGenerator7Toggle { get { return new XPlaneCommand("sim/electrical/generator_7_toggle", "Generator #7 toggle."); } }
        public static XPlaneCommand ElectricalGenerator8Toggle { get { return new XPlaneCommand("sim/electrical/generator_8_toggle", "Generator #8 toggle."); } }
        public static XPlaneCommand ElectricalGenerator1Reset { get { return new XPlaneCommand("sim/electrical/generator_1_reset", "Generator #1 reset."); } }
        public static XPlaneCommand ElectricalGenerator2Reset { get { return new XPlaneCommand("sim/electrical/generator_2_reset", "Generator #2 reset."); } }
        public static XPlaneCommand ElectricalGenerator3Reset { get { return new XPlaneCommand("sim/electrical/generator_3_reset", "Generator #3 reset."); } }
        public static XPlaneCommand ElectricalGenerator4Reset { get { return new XPlaneCommand("sim/electrical/generator_4_reset", "Generator #4 reset."); } }
        public static XPlaneCommand ElectricalGenerator5Reset { get { return new XPlaneCommand("sim/electrical/generator_5_reset", "Generator #5 reset."); } }
        public static XPlaneCommand ElectricalGenerator6Reset { get { return new XPlaneCommand("sim/electrical/generator_6_reset", "Generator #6 reset."); } }
        public static XPlaneCommand ElectricalGenerator7Reset { get { return new XPlaneCommand("sim/electrical/generator_7_reset", "Generator #7 reset."); } }
        public static XPlaneCommand ElectricalGenerator8Reset { get { return new XPlaneCommand("sim/electrical/generator_8_reset", "Generator #8 reset."); } }
        public static XPlaneCommand ElectricalAPUStart { get { return new XPlaneCommand("sim/electrical/APU_start", "APU start."); } }
        public static XPlaneCommand ElectricalAPUOn { get { return new XPlaneCommand("sim/electrical/APU_on", "APU on."); } }
        public static XPlaneCommand ElectricalAPUOff { get { return new XPlaneCommand("sim/electrical/APU_off", "APU off."); } }
        public static XPlaneCommand ElectricalAPUFireShutoff { get { return new XPlaneCommand("sim/electrical/APU_fire_shutoff", "APU emergency shutoff with fire handle."); } }
        public static XPlaneCommand ElectricalAPUGeneratorOn { get { return new XPlaneCommand("sim/electrical/APU_generator_on", "APU generator on."); } }
        public static XPlaneCommand ElectricalAPUGeneratorOff { get { return new XPlaneCommand("sim/electrical/APU_generator_off", "APU generator off."); } }
        public static XPlaneCommand ElectricalGPUOn { get { return new XPlaneCommand("sim/electrical/GPU_on", "GPU on."); } }
        public static XPlaneCommand ElectricalGPUOff { get { return new XPlaneCommand("sim/electrical/GPU_off", "GPU off."); } }
        public static XPlaneCommand ElectricalGPUToggle { get { return new XPlaneCommand("sim/electrical/GPU_toggle", "GPU toggle."); } }
        public static XPlaneCommand ElectricalRecharge { get { return new XPlaneCommand("sim/electrical/recharge", "Re-charge batteries."); } }
        public static XPlaneCommand LightsNavLightsOn { get { return new XPlaneCommand("sim/lights/nav_lights_on", "Nav lights on."); } }
        public static XPlaneCommand LightsNavLightsOff { get { return new XPlaneCommand("sim/lights/nav_lights_off", "Nav lights off."); } }
        public static XPlaneCommand LightsNavLightsToggle { get { return new XPlaneCommand("sim/lights/nav_lights_toggle", "Nav lights toggle."); } }
        public static XPlaneCommand LightsBeaconLightsOn { get { return new XPlaneCommand("sim/lights/beacon_lights_on", "Beacon lights on."); } }
        public static XPlaneCommand LightsBeaconLightsOff { get { return new XPlaneCommand("sim/lights/beacon_lights_off", "Beacon lights off."); } }
        public static XPlaneCommand LightsBeaconLightsToggle { get { return new XPlaneCommand("sim/lights/beacon_lights_toggle", "Beacon lights toggle."); } }
        public static XPlaneCommand LightsStrobeLightsOn { get { return new XPlaneCommand("sim/lights/strobe_lights_on", "Strobe lights on."); } }
        public static XPlaneCommand LightsStrobeLightsOff { get { return new XPlaneCommand("sim/lights/strobe_lights_off", "Strobe lights off."); } }
        public static XPlaneCommand LightsStrobeLightsToggle { get { return new XPlaneCommand("sim/lights/strobe_lights_toggle", "Strobe lights toggle."); } }
        public static XPlaneCommand LightsTaxiLightsOn { get { return new XPlaneCommand("sim/lights/taxi_lights_on", "Taxi lights on."); } }
        public static XPlaneCommand LightsTaxiLightsOff { get { return new XPlaneCommand("sim/lights/taxi_lights_off", "Taxi lights off."); } }
        public static XPlaneCommand LightsTaxiLightsToggle { get { return new XPlaneCommand("sim/lights/taxi_lights_toggle", "Taxi lights toggle."); } }
        public static XPlaneCommand LightsLandingLightsOn { get { return new XPlaneCommand("sim/lights/landing_lights_on", "Landing lights on."); } }
        public static XPlaneCommand LightsLandingLightsOff { get { return new XPlaneCommand("sim/lights/landing_lights_off", "Landing lights off."); } }
        public static XPlaneCommand LightsLandingLightsToggle { get { return new XPlaneCommand("sim/lights/landing_lights_toggle", "Landing lights toggle."); } }
        public static XPlaneCommand LightsLanding01LightOn { get { return new XPlaneCommand("sim/lights/landing_01_light_on", "Landing light 01 on."); } }
        public static XPlaneCommand LightsLanding02LightOn { get { return new XPlaneCommand("sim/lights/landing_02_light_on", "Landing light 02 on."); } }
        public static XPlaneCommand LightsLanding03LightOn { get { return new XPlaneCommand("sim/lights/landing_03_light_on", "Landing light 03 on."); } }
        public static XPlaneCommand LightsLanding04LightOn { get { return new XPlaneCommand("sim/lights/landing_04_light_on", "Landing light 04 on."); } }
        public static XPlaneCommand LightsLanding05LightOn { get { return new XPlaneCommand("sim/lights/landing_05_light_on", "Landing light 05 on."); } }
        public static XPlaneCommand LightsLanding06LightOn { get { return new XPlaneCommand("sim/lights/landing_06_light_on", "Landing light 06 on."); } }
        public static XPlaneCommand LightsLanding07LightOn { get { return new XPlaneCommand("sim/lights/landing_07_light_on", "Landing light 07 on."); } }
        public static XPlaneCommand LightsLanding08LightOn { get { return new XPlaneCommand("sim/lights/landing_08_light_on", "Landing light 08 on."); } }
        public static XPlaneCommand LightsLanding09LightOn { get { return new XPlaneCommand("sim/lights/landing_09_light_on", "Landing light 09 on."); } }
        public static XPlaneCommand LightsLanding10LightOn { get { return new XPlaneCommand("sim/lights/landing_10_light_on", "Landing light 10 on."); } }
        public static XPlaneCommand LightsLanding11LightOn { get { return new XPlaneCommand("sim/lights/landing_11_light_on", "Landing light 11 on."); } }
        public static XPlaneCommand LightsLanding12LightOn { get { return new XPlaneCommand("sim/lights/landing_12_light_on", "Landing light 12 on."); } }
        public static XPlaneCommand LightsLanding13LightOn { get { return new XPlaneCommand("sim/lights/landing_13_light_on", "Landing light 13 on."); } }
        public static XPlaneCommand LightsLanding14LightOn { get { return new XPlaneCommand("sim/lights/landing_14_light_on", "Landing light 14 on."); } }
        public static XPlaneCommand LightsLanding15LightOn { get { return new XPlaneCommand("sim/lights/landing_15_light_on", "Landing light 15 on."); } }
        public static XPlaneCommand LightsLanding16LightOn { get { return new XPlaneCommand("sim/lights/landing_16_light_on", "Landing light 16 on."); } }
        public static XPlaneCommand LightsLanding01LightOff { get { return new XPlaneCommand("sim/lights/landing_01_light_off", "Landing light 01 off."); } }
        public static XPlaneCommand LightsLanding02LightOff { get { return new XPlaneCommand("sim/lights/landing_02_light_off", "Landing light 02 off."); } }
        public static XPlaneCommand LightsLanding03LightOff { get { return new XPlaneCommand("sim/lights/landing_03_light_off", "Landing light 03 off."); } }
        public static XPlaneCommand LightsLanding04LightOff { get { return new XPlaneCommand("sim/lights/landing_04_light_off", "Landing light 04 off."); } }
        public static XPlaneCommand LightsLanding05LightOff { get { return new XPlaneCommand("sim/lights/landing_05_light_off", "Landing light 05 off."); } }
        public static XPlaneCommand LightsLanding06LightOff { get { return new XPlaneCommand("sim/lights/landing_06_light_off", "Landing light 06 off."); } }
        public static XPlaneCommand LightsLanding07LightOff { get { return new XPlaneCommand("sim/lights/landing_07_light_off", "Landing light 07 off."); } }
        public static XPlaneCommand LightsLanding08LightOff { get { return new XPlaneCommand("sim/lights/landing_08_light_off", "Landing light 08 off."); } }
        public static XPlaneCommand LightsLanding09LightOff { get { return new XPlaneCommand("sim/lights/landing_09_light_off", "Landing light 09 off."); } }
        public static XPlaneCommand LightsLanding10LightOff { get { return new XPlaneCommand("sim/lights/landing_10_light_off", "Landing light 10 off."); } }
        public static XPlaneCommand LightsLanding11LightOff { get { return new XPlaneCommand("sim/lights/landing_11_light_off", "Landing light 11 off."); } }
        public static XPlaneCommand LightsLanding12LightOff { get { return new XPlaneCommand("sim/lights/landing_12_light_off", "Landing light 12 off."); } }
        public static XPlaneCommand LightsLanding13LightOff { get { return new XPlaneCommand("sim/lights/landing_13_light_off", "Landing light 13 off."); } }
        public static XPlaneCommand LightsLanding14LightOff { get { return new XPlaneCommand("sim/lights/landing_14_light_off", "Landing light 14 off."); } }
        public static XPlaneCommand LightsLanding15LightOff { get { return new XPlaneCommand("sim/lights/landing_15_light_off", "Landing light 15 off."); } }
        public static XPlaneCommand LightsLanding16LightOff { get { return new XPlaneCommand("sim/lights/landing_16_light_off", "Landing light 16 off."); } }
        public static XPlaneCommand LightsLanding01LightTog { get { return new XPlaneCommand("sim/lights/landing_01_light_tog", "Landing light 01 toggle."); } }
        public static XPlaneCommand LightsLanding02LightTog { get { return new XPlaneCommand("sim/lights/landing_02_light_tog", "Landing light 02 toggle."); } }
        public static XPlaneCommand LightsLanding03LightTog { get { return new XPlaneCommand("sim/lights/landing_03_light_tog", "Landing light 03 toggle."); } }
        public static XPlaneCommand LightsLanding04LightTog { get { return new XPlaneCommand("sim/lights/landing_04_light_tog", "Landing light 04 toggle."); } }
        public static XPlaneCommand LightsLanding05LightTog { get { return new XPlaneCommand("sim/lights/landing_05_light_tog", "Landing light 05 toggle."); } }
        public static XPlaneCommand LightsLanding06LightTog { get { return new XPlaneCommand("sim/lights/landing_06_light_tog", "Landing light 06 toggle."); } }
        public static XPlaneCommand LightsLanding07LightTog { get { return new XPlaneCommand("sim/lights/landing_07_light_tog", "Landing light 07 toggle."); } }
        public static XPlaneCommand LightsLanding08LightTog { get { return new XPlaneCommand("sim/lights/landing_08_light_tog", "Landing light 08 toggle."); } }
        public static XPlaneCommand LightsLanding09LightTog { get { return new XPlaneCommand("sim/lights/landing_09_light_tog", "Landing light 09 toggle."); } }
        public static XPlaneCommand LightsLanding10LightTog { get { return new XPlaneCommand("sim/lights/landing_10_light_tog", "Landing light 10 toggle."); } }
        public static XPlaneCommand LightsLanding11LightTog { get { return new XPlaneCommand("sim/lights/landing_11_light_tog", "Landing light 11 toggle."); } }
        public static XPlaneCommand LightsLanding12LightTog { get { return new XPlaneCommand("sim/lights/landing_12_light_tog", "Landing light 12 toggle."); } }
        public static XPlaneCommand LightsLanding13LightTog { get { return new XPlaneCommand("sim/lights/landing_13_light_tog", "Landing light 13 toggle."); } }
        public static XPlaneCommand LightsLanding14LightTog { get { return new XPlaneCommand("sim/lights/landing_14_light_tog", "Landing light 14 toggle."); } }
        public static XPlaneCommand LightsLanding15LightTog { get { return new XPlaneCommand("sim/lights/landing_15_light_tog", "Landing light 15 toggle."); } }
        public static XPlaneCommand LightsLanding16LightTog { get { return new XPlaneCommand("sim/lights/landing_16_light_tog", "Landing light 16 toggle."); } }
        public static XPlaneCommand LightsGeneric01LightTog { get { return new XPlaneCommand("sim/lights/generic_01_light_tog", "Generic light 01 toggle."); } }
        public static XPlaneCommand LightsGeneric02LightTog { get { return new XPlaneCommand("sim/lights/generic_02_light_tog", "Generic light 02 toggle."); } }
        public static XPlaneCommand LightsGeneric03LightTog { get { return new XPlaneCommand("sim/lights/generic_03_light_tog", "Generic light 03 toggle."); } }
        public static XPlaneCommand LightsGeneric04LightTog { get { return new XPlaneCommand("sim/lights/generic_04_light_tog", "Generic light 04 toggle."); } }
        public static XPlaneCommand LightsGeneric05LightTog { get { return new XPlaneCommand("sim/lights/generic_05_light_tog", "Generic light 05 toggle."); } }
        public static XPlaneCommand LightsGeneric06LightTog { get { return new XPlaneCommand("sim/lights/generic_06_light_tog", "Generic light 06 toggle."); } }
        public static XPlaneCommand LightsGeneric07LightTog { get { return new XPlaneCommand("sim/lights/generic_07_light_tog", "Generic light 07 toggle."); } }
        public static XPlaneCommand LightsGeneric08LightTog { get { return new XPlaneCommand("sim/lights/generic_08_light_tog", "Generic light 08 toggle."); } }
        public static XPlaneCommand LightsGeneric09LightTog { get { return new XPlaneCommand("sim/lights/generic_09_light_tog", "Generic light 09 toggle."); } }
        public static XPlaneCommand LightsGeneric10LightTog { get { return new XPlaneCommand("sim/lights/generic_10_light_tog", "Generic light 10 toggle."); } }
        public static XPlaneCommand LightsGeneric11LightTog { get { return new XPlaneCommand("sim/lights/generic_11_light_tog", "Generic light 11 toggle."); } }
        public static XPlaneCommand LightsGeneric12LightTog { get { return new XPlaneCommand("sim/lights/generic_12_light_tog", "Generic light 12 toggle."); } }
        public static XPlaneCommand LightsGeneric13LightTog { get { return new XPlaneCommand("sim/lights/generic_13_light_tog", "Generic light 13 toggle."); } }
        public static XPlaneCommand LightsGeneric14LightTog { get { return new XPlaneCommand("sim/lights/generic_14_light_tog", "Generic light 14 toggle."); } }
        public static XPlaneCommand LightsGeneric15LightTog { get { return new XPlaneCommand("sim/lights/generic_15_light_tog", "Generic light 15 toggle."); } }
        public static XPlaneCommand LightsGeneric16LightTog { get { return new XPlaneCommand("sim/lights/generic_16_light_tog", "Generic light 16 toggle."); } }
        public static XPlaneCommand LightsGeneric17LightTog { get { return new XPlaneCommand("sim/lights/generic_17_light_tog", "Generic light 17 toggle."); } }
        public static XPlaneCommand LightsGeneric18LightTog { get { return new XPlaneCommand("sim/lights/generic_18_light_tog", "Generic light 18 toggle."); } }
        public static XPlaneCommand LightsGeneric19LightTog { get { return new XPlaneCommand("sim/lights/generic_19_light_tog", "Generic light 19 toggle."); } }
        public static XPlaneCommand LightsGeneric20LightTog { get { return new XPlaneCommand("sim/lights/generic_20_light_tog", "Generic light 20 toggle."); } }
        public static XPlaneCommand LightsGeneric21LightTog { get { return new XPlaneCommand("sim/lights/generic_21_light_tog", "Generic light 21 toggle."); } }
        public static XPlaneCommand LightsGeneric22LightTog { get { return new XPlaneCommand("sim/lights/generic_22_light_tog", "Generic light 22 toggle."); } }
        public static XPlaneCommand LightsGeneric23LightTog { get { return new XPlaneCommand("sim/lights/generic_23_light_tog", "Generic light 23 toggle."); } }
        public static XPlaneCommand LightsGeneric24LightTog { get { return new XPlaneCommand("sim/lights/generic_24_light_tog", "Generic light 24 toggle."); } }
        public static XPlaneCommand LightsGeneric25LightTog { get { return new XPlaneCommand("sim/lights/generic_25_light_tog", "Generic light 25 toggle."); } }
        public static XPlaneCommand LightsGeneric26LightTog { get { return new XPlaneCommand("sim/lights/generic_26_light_tog", "Generic light 26 toggle."); } }
        public static XPlaneCommand LightsGeneric27LightTog { get { return new XPlaneCommand("sim/lights/generic_27_light_tog", "Generic light 27 toggle."); } }
        public static XPlaneCommand LightsGeneric28LightTog { get { return new XPlaneCommand("sim/lights/generic_28_light_tog", "Generic light 28 toggle."); } }
        public static XPlaneCommand LightsGeneric29LightTog { get { return new XPlaneCommand("sim/lights/generic_29_light_tog", "Generic light 29 toggle."); } }
        public static XPlaneCommand LightsGeneric30LightTog { get { return new XPlaneCommand("sim/lights/generic_30_light_tog", "Generic light 30 toggle."); } }
        public static XPlaneCommand LightsGeneric31LightTog { get { return new XPlaneCommand("sim/lights/generic_31_light_tog", "Generic light 31 toggle."); } }
        public static XPlaneCommand LightsGeneric32LightTog { get { return new XPlaneCommand("sim/lights/generic_32_light_tog", "Generic light 32 toggle."); } }
        public static XPlaneCommand LightsGeneric33LightTog { get { return new XPlaneCommand("sim/lights/generic_33_light_tog", "Generic light 33 toggle."); } }
        public static XPlaneCommand LightsGeneric34LightTog { get { return new XPlaneCommand("sim/lights/generic_34_light_tog", "Generic light 34 toggle."); } }
        public static XPlaneCommand LightsGeneric35LightTog { get { return new XPlaneCommand("sim/lights/generic_35_light_tog", "Generic light 35 toggle."); } }
        public static XPlaneCommand LightsGeneric36LightTog { get { return new XPlaneCommand("sim/lights/generic_36_light_tog", "Generic light 36 toggle."); } }
        public static XPlaneCommand LightsGeneric37LightTog { get { return new XPlaneCommand("sim/lights/generic_37_light_tog", "Generic light 37 toggle."); } }
        public static XPlaneCommand LightsGeneric38LightTog { get { return new XPlaneCommand("sim/lights/generic_38_light_tog", "Generic light 38 toggle."); } }
        public static XPlaneCommand LightsGeneric39LightTog { get { return new XPlaneCommand("sim/lights/generic_39_light_tog", "Generic light 39 toggle."); } }
        public static XPlaneCommand LightsGeneric40LightTog { get { return new XPlaneCommand("sim/lights/generic_40_light_tog", "Generic light 40 toggle."); } }
        public static XPlaneCommand LightsGeneric41LightTog { get { return new XPlaneCommand("sim/lights/generic_41_light_tog", "Generic light 41 toggle."); } }
        public static XPlaneCommand LightsGeneric42LightTog { get { return new XPlaneCommand("sim/lights/generic_42_light_tog", "Generic light 42 toggle."); } }
        public static XPlaneCommand LightsGeneric43LightTog { get { return new XPlaneCommand("sim/lights/generic_43_light_tog", "Generic light 43 toggle."); } }
        public static XPlaneCommand LightsGeneric44LightTog { get { return new XPlaneCommand("sim/lights/generic_44_light_tog", "Generic light 44 toggle."); } }
        public static XPlaneCommand LightsGeneric45LightTog { get { return new XPlaneCommand("sim/lights/generic_45_light_tog", "Generic light 45 toggle."); } }
        public static XPlaneCommand LightsGeneric46LightTog { get { return new XPlaneCommand("sim/lights/generic_46_light_tog", "Generic light 46 toggle."); } }
        public static XPlaneCommand LightsGeneric47LightTog { get { return new XPlaneCommand("sim/lights/generic_47_light_tog", "Generic light 47 toggle."); } }
        public static XPlaneCommand LightsGeneric48LightTog { get { return new XPlaneCommand("sim/lights/generic_48_light_tog", "Generic light 48 toggle."); } }
        public static XPlaneCommand LightsGeneric49LightTog { get { return new XPlaneCommand("sim/lights/generic_49_light_tog", "Generic light 49 toggle."); } }
        public static XPlaneCommand LightsGeneric50LightTog { get { return new XPlaneCommand("sim/lights/generic_50_light_tog", "Generic light 50 toggle."); } }
        public static XPlaneCommand LightsGeneric51LightTog { get { return new XPlaneCommand("sim/lights/generic_51_light_tog", "Generic light 51 toggle."); } }
        public static XPlaneCommand LightsGeneric52LightTog { get { return new XPlaneCommand("sim/lights/generic_52_light_tog", "Generic light 52 toggle."); } }
        public static XPlaneCommand LightsGeneric53LightTog { get { return new XPlaneCommand("sim/lights/generic_53_light_tog", "Generic light 53 toggle."); } }
        public static XPlaneCommand LightsGeneric54LightTog { get { return new XPlaneCommand("sim/lights/generic_54_light_tog", "Generic light 54 toggle."); } }
        public static XPlaneCommand LightsGeneric55LightTog { get { return new XPlaneCommand("sim/lights/generic_55_light_tog", "Generic light 55 toggle."); } }
        public static XPlaneCommand LightsGeneric56LightTog { get { return new XPlaneCommand("sim/lights/generic_56_light_tog", "Generic light 56 toggle."); } }
        public static XPlaneCommand LightsGeneric57LightTog { get { return new XPlaneCommand("sim/lights/generic_57_light_tog", "Generic light 57 toggle."); } }
        public static XPlaneCommand LightsGeneric58LightTog { get { return new XPlaneCommand("sim/lights/generic_58_light_tog", "Generic light 58 toggle."); } }
        public static XPlaneCommand LightsGeneric59LightTog { get { return new XPlaneCommand("sim/lights/generic_59_light_tog", "Generic light 59 toggle."); } }
        public static XPlaneCommand LightsGeneric60LightTog { get { return new XPlaneCommand("sim/lights/generic_60_light_tog", "Generic light 60 toggle."); } }
        public static XPlaneCommand LightsGeneric61LightTog { get { return new XPlaneCommand("sim/lights/generic_61_light_tog", "Generic light 61 toggle."); } }
        public static XPlaneCommand LightsGeneric62LightTog { get { return new XPlaneCommand("sim/lights/generic_62_light_tog", "Generic light 62 toggle."); } }
        public static XPlaneCommand LightsGeneric63LightTog { get { return new XPlaneCommand("sim/lights/generic_63_light_tog", "Generic light 63 toggle."); } }
        public static XPlaneCommand LightsGeneric64LightTog { get { return new XPlaneCommand("sim/lights/generic_64_light_tog", "Generic light 64 toggle."); } }
        public static XPlaneCommand LightsSpotLightsOn { get { return new XPlaneCommand("sim/lights/spot_lights_on", "Spot lights on."); } }
        public static XPlaneCommand LightsSpotLightsOff { get { return new XPlaneCommand("sim/lights/spot_lights_off", "Spot lights off."); } }
        public static XPlaneCommand LightsSpotLightsToggle { get { return new XPlaneCommand("sim/lights/spot_lights_toggle", "Spot lights toggle."); } }
        public static XPlaneCommand SystemsAvionicsOn { get { return new XPlaneCommand("sim/systems/avionics_on", "Avionics on."); } }
        public static XPlaneCommand SystemsAvionicsOff { get { return new XPlaneCommand("sim/systems/avionics_off", "Avionics off."); } }
        public static XPlaneCommand SystemsAvionicsToggle { get { return new XPlaneCommand("sim/systems/avionics_toggle", "Avionics toggle."); } }
        public static XPlaneCommand BleedAirBleedAirDown { get { return new XPlaneCommand("sim/bleed_air/bleed_air_down", "Bleed air mode down."); } }
        public static XPlaneCommand BleedAirBleedAirUp { get { return new XPlaneCommand("sim/bleed_air/bleed_air_up", "Bleed air mode up."); } }
        public static XPlaneCommand BleedAirBleedAirOff { get { return new XPlaneCommand("sim/bleed_air/bleed_air_off", "Bleed air off."); } }
        public static XPlaneCommand BleedAirBleedAirLeft { get { return new XPlaneCommand("sim/bleed_air/bleed_air_left", "Bleed air from left engine."); } }
        public static XPlaneCommand BleedAirBleedAirBoth { get { return new XPlaneCommand("sim/bleed_air/bleed_air_both", "Bleed air from either engine."); } }
        public static XPlaneCommand BleedAirBleedAirRight { get { return new XPlaneCommand("sim/bleed_air/bleed_air_right", "Bleed air from right engine."); } }
        public static XPlaneCommand BleedAirBleedAirApu { get { return new XPlaneCommand("sim/bleed_air/bleed_air_apu", "Bleed air from APU."); } }
        public static XPlaneCommand BleedAirBleedAirAuto { get { return new XPlaneCommand("sim/bleed_air/bleed_air_auto", "Bleed air from any engine or APU."); } }
        public static XPlaneCommand BleedAirBleedAirLeftOn { get { return new XPlaneCommand("sim/bleed_air/bleed_air_left_on", "Bleed air left engine on."); } }
        public static XPlaneCommand BleedAirBleedAirLeftInsOnly { get { return new XPlaneCommand("sim/bleed_air/bleed_air_left_ins_only", "Bleed air left engine instruments only."); } }
        public static XPlaneCommand BleedAirBleedAirLeftOff { get { return new XPlaneCommand("sim/bleed_air/bleed_air_left_off", "Bleed air left engine off."); } }
        public static XPlaneCommand BleedAirBleedAirRightOn { get { return new XPlaneCommand("sim/bleed_air/bleed_air_right_on", "Bleed air right engine on."); } }
        public static XPlaneCommand BleedAirBleedAirRightInsOnly { get { return new XPlaneCommand("sim/bleed_air/bleed_air_right_ins_only", "Bleed air right engine instruments only."); } }
        public static XPlaneCommand BleedAirBleedAirRightOff { get { return new XPlaneCommand("sim/bleed_air/bleed_air_right_off", "Bleed air right engine off."); } }
        public static XPlaneCommand BleedAirEngine1Off { get { return new XPlaneCommand("sim/bleed_air/engine_1_off", "Bleed air shut off engine 1."); } }
        public static XPlaneCommand BleedAirEngine2Off { get { return new XPlaneCommand("sim/bleed_air/engine_2_off", "Bleed air shut off engine 2."); } }
        public static XPlaneCommand BleedAirEngine3Off { get { return new XPlaneCommand("sim/bleed_air/engine_3_off", "Bleed air shut off engine 3."); } }
        public static XPlaneCommand BleedAirEngine4Off { get { return new XPlaneCommand("sim/bleed_air/engine_4_off", "Bleed air shut off engine 4."); } }
        public static XPlaneCommand BleedAirEngine5Off { get { return new XPlaneCommand("sim/bleed_air/engine_5_off", "Bleed air shut off engine 5."); } }
        public static XPlaneCommand BleedAirEngine6Off { get { return new XPlaneCommand("sim/bleed_air/engine_6_off", "Bleed air shut off engine 6."); } }
        public static XPlaneCommand BleedAirEngine7Off { get { return new XPlaneCommand("sim/bleed_air/engine_7_off", "Bleed air shut off engine 7."); } }
        public static XPlaneCommand BleedAirEngine8Off { get { return new XPlaneCommand("sim/bleed_air/engine_8_off", "Bleed air shut off engine 8."); } }
        public static XPlaneCommand BleedAirEngine1On { get { return new XPlaneCommand("sim/bleed_air/engine_1_on", "Bleed air on engine 1."); } }
        public static XPlaneCommand BleedAirEngine2On { get { return new XPlaneCommand("sim/bleed_air/engine_2_on", "Bleed air on engine 2."); } }
        public static XPlaneCommand BleedAirEngine3On { get { return new XPlaneCommand("sim/bleed_air/engine_3_on", "Bleed air on engine 3."); } }
        public static XPlaneCommand BleedAirEngine4On { get { return new XPlaneCommand("sim/bleed_air/engine_4_on", "Bleed air on engine 4."); } }
        public static XPlaneCommand BleedAirEngine5On { get { return new XPlaneCommand("sim/bleed_air/engine_5_on", "Bleed air on engine 5."); } }
        public static XPlaneCommand BleedAirEngine6On { get { return new XPlaneCommand("sim/bleed_air/engine_6_on", "Bleed air on engine 6."); } }
        public static XPlaneCommand BleedAirEngine7On { get { return new XPlaneCommand("sim/bleed_air/engine_7_on", "Bleed air on engine 7."); } }
        public static XPlaneCommand BleedAirEngine8On { get { return new XPlaneCommand("sim/bleed_air/engine_8_on", "Bleed air on engine 8."); } }
        public static XPlaneCommand BleedAirEngine1Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_1_toggle", "Bleed air toggle engine 1."); } }
        public static XPlaneCommand BleedAirEngine2Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_2_toggle", "Bleed air toggle engine 2."); } }
        public static XPlaneCommand BleedAirEngine3Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_3_toggle", "Bleed air toggle engine 3."); } }
        public static XPlaneCommand BleedAirEngine4Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_4_toggle", "Bleed air toggle engine 4."); } }
        public static XPlaneCommand BleedAirEngine5Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_5_toggle", "Bleed air toggle engine 5."); } }
        public static XPlaneCommand BleedAirEngine6Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_6_toggle", "Bleed air toggle engine 6."); } }
        public static XPlaneCommand BleedAirEngine7Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_7_toggle", "Bleed air toggle engine 7."); } }
        public static XPlaneCommand BleedAirEngine8Toggle { get { return new XPlaneCommand("sim/bleed_air/engine_8_toggle", "Bleed air toggle engine 8."); } }
        public static XPlaneCommand BleedAirGpuOff { get { return new XPlaneCommand("sim/bleed_air/gpu_off", "Bleed air shut off GPU."); } }
        public static XPlaneCommand BleedAirGpuOn { get { return new XPlaneCommand("sim/bleed_air/gpu_on", "Bleed air on GPU."); } }
        public static XPlaneCommand BleedAirGpuToggle { get { return new XPlaneCommand("sim/bleed_air/gpu_toggle", "Bleed air toggle GPU."); } }
        public static XPlaneCommand BleedAirApuOff { get { return new XPlaneCommand("sim/bleed_air/apu_off", "Bleed air shut off APU."); } }
        public static XPlaneCommand BleedAirApuOn { get { return new XPlaneCommand("sim/bleed_air/apu_on", "Bleed air on APU."); } }
        public static XPlaneCommand BleedAirApuToggle { get { return new XPlaneCommand("sim/bleed_air/apu_toggle", "Bleed air toggle APU."); } }
        public static XPlaneCommand BleedAirIsolationLeftShut { get { return new XPlaneCommand("sim/bleed_air/isolation_left_shut", "Bleed air shut left isolation."); } }
        public static XPlaneCommand BleedAirIsolationLeftOpen { get { return new XPlaneCommand("sim/bleed_air/isolation_left_open", "Bleed air open left isolation."); } }
        public static XPlaneCommand BleedAirIsolationLeftToggle { get { return new XPlaneCommand("sim/bleed_air/isolation_left_toggle", "Bleed air toggle left isolation."); } }
        public static XPlaneCommand BleedAirIsolationRightShut { get { return new XPlaneCommand("sim/bleed_air/isolation_right_shut", "Bleed air shut right isolation."); } }
        public static XPlaneCommand BleedAirIsolationRightOpen { get { return new XPlaneCommand("sim/bleed_air/isolation_right_open", "Bleed air open right isolation."); } }
        public static XPlaneCommand BleedAirIsolationRightToggle { get { return new XPlaneCommand("sim/bleed_air/isolation_right_toggle", "Bleed air toggle right isolation."); } }
        public static XPlaneCommand BleedAirPackLeftOff { get { return new XPlaneCommand("sim/bleed_air/pack_left_off", "Bleed air left pack off."); } }
        public static XPlaneCommand BleedAirPackLeftOn { get { return new XPlaneCommand("sim/bleed_air/pack_left_on", "Bleed air left pack on."); } }
        public static XPlaneCommand BleedAirPackLeftToggle { get { return new XPlaneCommand("sim/bleed_air/pack_left_toggle", "Bleed air left pack toggle."); } }
        public static XPlaneCommand BleedAirPackCenterOff { get { return new XPlaneCommand("sim/bleed_air/pack_center_off", "Bleed air center pack off."); } }
        public static XPlaneCommand BleedAirPackCenterOn { get { return new XPlaneCommand("sim/bleed_air/pack_center_on", "Bleed air center pack on."); } }
        public static XPlaneCommand BleedAirPackCenterToggle { get { return new XPlaneCommand("sim/bleed_air/pack_center_toggle", "Bleed air center pack toggle."); } }
        public static XPlaneCommand BleedAirPackRightOff { get { return new XPlaneCommand("sim/bleed_air/pack_right_off", "Bleed air right pack off."); } }
        public static XPlaneCommand BleedAirPackRightOn { get { return new XPlaneCommand("sim/bleed_air/pack_right_on", "Bleed air right pack on."); } }
        public static XPlaneCommand BleedAirPackRightToggle { get { return new XPlaneCommand("sim/bleed_air/pack_right_toggle", "Bleed air right pack toggle."); } }
        public static XPlaneCommand PressurizationTest { get { return new XPlaneCommand("sim/pressurization/test", "Pressurization test."); } }
        public static XPlaneCommand PressurizationDumpOn { get { return new XPlaneCommand("sim/pressurization/dump_on", "Dump pressurization on."); } }
        public static XPlaneCommand PressurizationDumpOff { get { return new XPlaneCommand("sim/pressurization/dump_off", "Dump pressurization off."); } }
        public static XPlaneCommand PressurizationVviDown { get { return new XPlaneCommand("sim/pressurization/vvi_down", "Cabin vertical speed down."); } }
        public static XPlaneCommand PressurizationVviUp { get { return new XPlaneCommand("sim/pressurization/vvi_up", "Cabin vertical speed up."); } }
        public static XPlaneCommand PressurizationCabinAltDown { get { return new XPlaneCommand("sim/pressurization/cabin_alt_down", "Cabin altitude down."); } }
        public static XPlaneCommand PressurizationCabinAltUp { get { return new XPlaneCommand("sim/pressurization/cabin_alt_up", "Cabin altitude up."); } }
        public static XPlaneCommand PressurizationAircondOn { get { return new XPlaneCommand("sim/pressurization/aircond_on", "Air conditioning on."); } }
        public static XPlaneCommand PressurizationAircondOff { get { return new XPlaneCommand("sim/pressurization/aircond_off", "Air conditioning off."); } }
        public static XPlaneCommand PressurizationHeaterOn { get { return new XPlaneCommand("sim/pressurization/heater_on", "Electric heater on."); } }
        public static XPlaneCommand PressurizationHeaterGrdMax { get { return new XPlaneCommand("sim/pressurization/heater_grd_max", "Electric heater on ground max."); } }
        public static XPlaneCommand PressurizationHeaterOff { get { return new XPlaneCommand("sim/pressurization/heater_off", "Electric heater off."); } }
        public static XPlaneCommand PressurizationHeaterUp { get { return new XPlaneCommand("sim/pressurization/heater_up", "Electric heater off->on->grd max."); } }
        public static XPlaneCommand PressurizationHeaterDn { get { return new XPlaneCommand("sim/pressurization/heater_dn", "Electric heater grd max->on->off."); } }
        public static XPlaneCommand PressurizationFanAuto { get { return new XPlaneCommand("sim/pressurization/fan_auto", "Vent fan auto (on only with AC or heat)."); } }
        public static XPlaneCommand PressurizationFanLow { get { return new XPlaneCommand("sim/pressurization/fan_low", "Vent fan on low."); } }
        public static XPlaneCommand PressurizationFanHigh { get { return new XPlaneCommand("sim/pressurization/fan_high", "Vent fan high."); } }
        public static XPlaneCommand PressurizationFanUp { get { return new XPlaneCommand("sim/pressurization/fan_up", "Vent fan setting up."); } }
        public static XPlaneCommand PressurizationFanDown { get { return new XPlaneCommand("sim/pressurization/fan_down", "Vent fan setting down."); } }
        public static XPlaneCommand IceAntiIceToggle { get { return new XPlaneCommand("sim/ice/anti_ice_toggle", "Anti-ice: toggle all."); } }
        public static XPlaneCommand IceAlternateStaticPort { get { return new XPlaneCommand("sim/ice/alternate_static_port", "Toggle alternate static port."); } }
        public static XPlaneCommand IcePitotHeat0On { get { return new XPlaneCommand("sim/ice/pitot_heat0_on", "Anti-ice: left pitot heat on."); } }
        public static XPlaneCommand IcePitotHeat1On { get { return new XPlaneCommand("sim/ice/pitot_heat1_on", "Anti-ice: right pitot heat on."); } }
        public static XPlaneCommand IcePitotHeat0Off { get { return new XPlaneCommand("sim/ice/pitot_heat0_off", "Anti-ice: left pitot heat off."); } }
        public static XPlaneCommand IcePitotHeat1Off { get { return new XPlaneCommand("sim/ice/pitot_heat1_off", "Anti-ice: right pitot heat off."); } }
        public static XPlaneCommand IcePitotHeat0Tog { get { return new XPlaneCommand("sim/ice/pitot_heat0_tog", "Anti-ice: left pitot heat toggle."); } }
        public static XPlaneCommand IcePitotHeat1Tog { get { return new XPlaneCommand("sim/ice/pitot_heat1_tog", "Anti-ice: right pitot heat toggle."); } }
        public static XPlaneCommand IceStaticHeat0On { get { return new XPlaneCommand("sim/ice/static_heat0_on", "Anti-ice: left static heat on."); } }
        public static XPlaneCommand IceStaticHeat1On { get { return new XPlaneCommand("sim/ice/static_heat1_on", "Anti-ice: right static heat on."); } }
        public static XPlaneCommand IceStaticHeat0Off { get { return new XPlaneCommand("sim/ice/static_heat0_off", "Anti-ice: left static heat off."); } }
        public static XPlaneCommand IceStaticHeat1Off { get { return new XPlaneCommand("sim/ice/static_heat1_off", "Anti-ice: right static heat off."); } }
        public static XPlaneCommand IceStaticHeat0Tog { get { return new XPlaneCommand("sim/ice/static_heat0_tog", "Anti-ice: left static heat toggle."); } }
        public static XPlaneCommand IceStaticHeat1Tog { get { return new XPlaneCommand("sim/ice/static_heat1_tog", "Anti-ice: right static heat toggle."); } }
        public static XPlaneCommand IceAOAHeat0On { get { return new XPlaneCommand("sim/ice/AOA_heat0_on", "Anti-ice: AOA on."); } }
        public static XPlaneCommand IceAOAHeat1On { get { return new XPlaneCommand("sim/ice/AOA_heat1_on", "Anti-ice: AOA on."); } }
        public static XPlaneCommand IceAOAHeat0Off { get { return new XPlaneCommand("sim/ice/AOA_heat0_off", "Anti-ice: AOA off."); } }
        public static XPlaneCommand IceAOAHeat1Off { get { return new XPlaneCommand("sim/ice/AOA_heat1_off", "Anti-ice: AOA off."); } }
        public static XPlaneCommand IceAOAHeat0Tog { get { return new XPlaneCommand("sim/ice/AOA_heat0_tog", "Anti-ice: AOA toggle."); } }
        public static XPlaneCommand IceAOAHeat1Tog { get { return new XPlaneCommand("sim/ice/AOA_heat1_tog", "Anti-ice: AOA toggle."); } }
        public static XPlaneCommand IceWindowHeatOn { get { return new XPlaneCommand("sim/ice/window_heat_on", "Anti-ice: window heat on."); } }
        public static XPlaneCommand IceWindowHeatOff { get { return new XPlaneCommand("sim/ice/window_heat_off", "Anti-ice: window heat off."); } }
        public static XPlaneCommand IceWindowHeatTog { get { return new XPlaneCommand("sim/ice/window_heat_tog", "Anti-ice: window heat toggle."); } }
        public static XPlaneCommand IceWingHeatOn { get { return new XPlaneCommand("sim/ice/wing_heat_on", "Anti-ice: all wing, anti-ice heat on."); } }
        public static XPlaneCommand IceWingHeat0On { get { return new XPlaneCommand("sim/ice/wing_heat0_on", "Anti-ice: left wing, anti-ice heat on."); } }
        public static XPlaneCommand IceWingHeat1On { get { return new XPlaneCommand("sim/ice/wing_heat1_on", "Anti-ice: right wing, anti-ice heat on."); } }
        public static XPlaneCommand IceWingHeatOff { get { return new XPlaneCommand("sim/ice/wing_heat_off", "Anti-ice: all wing, anti-ice heat off."); } }
        public static XPlaneCommand IceWingHeat0Off { get { return new XPlaneCommand("sim/ice/wing_heat0_off", "Anti-ice: left wing, anti-ice heat off."); } }
        public static XPlaneCommand IceWingHeat1Off { get { return new XPlaneCommand("sim/ice/wing_heat1_off", "Anti-ice: right wing, anti-ice heat off."); } }
        public static XPlaneCommand IceWingHeatTog { get { return new XPlaneCommand("sim/ice/wing_heat_tog", "Anti-ice: all wing, anti-ice heat toggle."); } }
        public static XPlaneCommand IceWingHeat0Tog { get { return new XPlaneCommand("sim/ice/wing_heat0_tog", "Anti-ice: left wing, anti-ice heat toggle."); } }
        public static XPlaneCommand IceWingHeat1Tog { get { return new XPlaneCommand("sim/ice/wing_heat1_tog", "Anti-ice: right wing, anti-ice heat toggle."); } }
        public static XPlaneCommand IceWingBootOn { get { return new XPlaneCommand("sim/ice/wing_boot_on", "Anti-ice: all wing, de-icing boots on schedule."); } }
        public static XPlaneCommand IceWingBoot0On { get { return new XPlaneCommand("sim/ice/wing_boot0_on", "Anti-ice: left wing, de-icing boots on schedule."); } }
        public static XPlaneCommand IceWingBoot1On { get { return new XPlaneCommand("sim/ice/wing_boot1_on", "Anti-ice: right wing, de-icing boots on schedule."); } }
        public static XPlaneCommand IceWingBootOff { get { return new XPlaneCommand("sim/ice/wing_boot_off", "Anti-ice: all wing, de-icing boots off."); } }
        public static XPlaneCommand IceWingBoot0Off { get { return new XPlaneCommand("sim/ice/wing_boot0_off", "Anti-ice: left wing, de-icing boots off."); } }
        public static XPlaneCommand IceWingBoot1Off { get { return new XPlaneCommand("sim/ice/wing_boot1_off", "Anti-ice: right wing, de-icing boots off."); } }
        public static XPlaneCommand IceWingBootTog { get { return new XPlaneCommand("sim/ice/wing_boot_tog", "Anti-ice: all wing, de-icing boots toggle."); } }
        public static XPlaneCommand IceWingBoot0Tog { get { return new XPlaneCommand("sim/ice/wing_boot0_tog", "Anti-ice: left wing, de-icing boots toggle."); } }
        public static XPlaneCommand IceWingBoot1Tog { get { return new XPlaneCommand("sim/ice/wing_boot1_tog", "Anti-ice: right wing, de-icing boots toggle."); } }
        public static XPlaneCommand IceWingTaiOn { get { return new XPlaneCommand("sim/ice/wing_tai_on", "Anti-ice: all wing, bleed anti-ice on."); } }
        public static XPlaneCommand IceWingTai0On { get { return new XPlaneCommand("sim/ice/wing_tai0_on", "Anti-ice: left wing, bleed anti-ice on."); } }
        public static XPlaneCommand IceWingTai1On { get { return new XPlaneCommand("sim/ice/wing_tai1_on", "Anti-ice: right wing, bleed anti-ice on."); } }
        public static XPlaneCommand IceWingTaiOff { get { return new XPlaneCommand("sim/ice/wing_tai_off", "Anti-ice: all wing, bleed anti-ice off."); } }
        public static XPlaneCommand IceWingTai0Off { get { return new XPlaneCommand("sim/ice/wing_tai0_off", "Anti-ice: left wing, bleed anti-ice off."); } }
        public static XPlaneCommand IceWingTai1Off { get { return new XPlaneCommand("sim/ice/wing_tai1_off", "Anti-ice: right wing, bleed anti-ice off."); } }
        public static XPlaneCommand IceWingTaiTog { get { return new XPlaneCommand("sim/ice/wing_tai_tog", "Anti-ice: all wing, bleed anti-ice toggle."); } }
        public static XPlaneCommand IceWingTai0Tog { get { return new XPlaneCommand("sim/ice/wing_tai0_tog", "Anti-ice: left wing, bleed anti-ice toggle."); } }
        public static XPlaneCommand IceWingTai1Tog { get { return new XPlaneCommand("sim/ice/wing_tai1_tog", "Anti-ice: right wing, bleed anti-ice toggle."); } }
        public static XPlaneCommand IceWingTksOn { get { return new XPlaneCommand("sim/ice/wing_tks_on", "Anti-ice: all wing, TKS de-ice normal."); } }
        public static XPlaneCommand IceWingTks0On { get { return new XPlaneCommand("sim/ice/wing_tks0_on", "Anti-ice: left wing, TKS de-ice normal."); } }
        public static XPlaneCommand IceWingTks1On { get { return new XPlaneCommand("sim/ice/wing_tks1_on", "Anti-ice: right wing, TKS de-ice normal."); } }
        public static XPlaneCommand IceWingTksHigh { get { return new XPlaneCommand("sim/ice/wing_tks_high", "Anti-ice: all wing, TKS de-ice high."); } }
        public static XPlaneCommand IceWingTks0High { get { return new XPlaneCommand("sim/ice/wing_tks0_high", "Anti-ice: left wing, TKS de-ice high."); } }
        public static XPlaneCommand IceWingTks1High { get { return new XPlaneCommand("sim/ice/wing_tks1_high", "Anti-ice: right wing, TKS de-ice high."); } }
        public static XPlaneCommand IceWingTksOff { get { return new XPlaneCommand("sim/ice/wing_tks_off", "Anti-ice: all wing, TKS de-ice off."); } }
        public static XPlaneCommand IceWingTks0Off { get { return new XPlaneCommand("sim/ice/wing_tks0_off", "Anti-ice: left wing, TKS de-ice off."); } }
        public static XPlaneCommand IceWingTks1Off { get { return new XPlaneCommand("sim/ice/wing_tks1_off", "Anti-ice: right wing, TKS de-ice off."); } }
        public static XPlaneCommand IceWingTksTog { get { return new XPlaneCommand("sim/ice/wing_tks_tog", "Anti-ice: all wing, TKS de-ice toggle."); } }
        public static XPlaneCommand IceWingTks0Tog { get { return new XPlaneCommand("sim/ice/wing_tks0_tog", "Anti-ice: left wing, TKS de-ice toggle."); } }
        public static XPlaneCommand IceWingTks1Tog { get { return new XPlaneCommand("sim/ice/wing_tks1_tog", "Anti-ice: right wing, TKS de-ice toggle."); } }
        public static XPlaneCommand IceInletHeatOn { get { return new XPlaneCommand("sim/ice/inlet_heat_on", "Anti-ice: all engines inlet heat on."); } }
        public static XPlaneCommand IceInletHeatOff { get { return new XPlaneCommand("sim/ice/inlet_heat_off", "Anti-ice: all engines inlet heat off."); } }
        public static XPlaneCommand IceInletHeatTog { get { return new XPlaneCommand("sim/ice/inlet_heat_tog", "Anti-ice: all engines inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat0On { get { return new XPlaneCommand("sim/ice/inlet_heat0_on", "Anti-ice: engine #1 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat1On { get { return new XPlaneCommand("sim/ice/inlet_heat1_on", "Anti-ice: engine #2 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat2On { get { return new XPlaneCommand("sim/ice/inlet_heat2_on", "Anti-ice: engine #3 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat3On { get { return new XPlaneCommand("sim/ice/inlet_heat3_on", "Anti-ice: engine #4 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat4On { get { return new XPlaneCommand("sim/ice/inlet_heat4_on", "Anti-ice: engine #5 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat5On { get { return new XPlaneCommand("sim/ice/inlet_heat5_on", "Anti-ice: engine #6 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat6On { get { return new XPlaneCommand("sim/ice/inlet_heat6_on", "Anti-ice: engine #7 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat7On { get { return new XPlaneCommand("sim/ice/inlet_heat7_on", "Anti-ice: engine #8 inlet heat on."); } }
        public static XPlaneCommand IceInletHeat0Off { get { return new XPlaneCommand("sim/ice/inlet_heat0_off", "Anti-ice: engine #1 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat1Off { get { return new XPlaneCommand("sim/ice/inlet_heat1_off", "Anti-ice: engine #2 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat2Off { get { return new XPlaneCommand("sim/ice/inlet_heat2_off", "Anti-ice: engine #3 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat3Off { get { return new XPlaneCommand("sim/ice/inlet_heat3_off", "Anti-ice: engine #4 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat4Off { get { return new XPlaneCommand("sim/ice/inlet_heat4_off", "Anti-ice: engine #5 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat5Off { get { return new XPlaneCommand("sim/ice/inlet_heat5_off", "Anti-ice: engine #6 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat6Off { get { return new XPlaneCommand("sim/ice/inlet_heat6_off", "Anti-ice: engine #7 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat7Off { get { return new XPlaneCommand("sim/ice/inlet_heat7_off", "Anti-ice: engine #8 inlet heat off."); } }
        public static XPlaneCommand IceInletHeat0Tog { get { return new XPlaneCommand("sim/ice/inlet_heat0_tog", "Anti-ice: engine #1 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat1Tog { get { return new XPlaneCommand("sim/ice/inlet_heat1_tog", "Anti-ice: engine #2 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat2Tog { get { return new XPlaneCommand("sim/ice/inlet_heat2_tog", "Anti-ice: engine #3 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat3Tog { get { return new XPlaneCommand("sim/ice/inlet_heat3_tog", "Anti-ice: engine #4 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat4Tog { get { return new XPlaneCommand("sim/ice/inlet_heat4_tog", "Anti-ice: engine #5 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat5Tog { get { return new XPlaneCommand("sim/ice/inlet_heat5_tog", "Anti-ice: engine #6 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat6Tog { get { return new XPlaneCommand("sim/ice/inlet_heat6_tog", "Anti-ice: engine #7 inlet heat toggle."); } }
        public static XPlaneCommand IceInletHeat7Tog { get { return new XPlaneCommand("sim/ice/inlet_heat7_tog", "Anti-ice: engine #8 inlet heat toggle."); } }
        public static XPlaneCommand IceInletEai0On { get { return new XPlaneCommand("sim/ice/inlet_eai0_on", "Anti-ice: engine #1 anti-ice on."); } }
        public static XPlaneCommand IceInletEai1On { get { return new XPlaneCommand("sim/ice/inlet_eai1_on", "Anti-ice: engine #2 anti-ice on."); } }
        public static XPlaneCommand IceInletEai2On { get { return new XPlaneCommand("sim/ice/inlet_eai2_on", "Anti-ice: engine #3 anti-ice on."); } }
        public static XPlaneCommand IceInletEai3On { get { return new XPlaneCommand("sim/ice/inlet_eai3_on", "Anti-ice: engine #4 anti-ice on."); } }
        public static XPlaneCommand IceInletEai4On { get { return new XPlaneCommand("sim/ice/inlet_eai4_on", "Anti-ice: engine #5 anti-ice on."); } }
        public static XPlaneCommand IceInletEai5On { get { return new XPlaneCommand("sim/ice/inlet_eai5_on", "Anti-ice: engine #6 anti-ice on."); } }
        public static XPlaneCommand IceInletEai6On { get { return new XPlaneCommand("sim/ice/inlet_eai6_on", "Anti-ice: engine #7 anti-ice on."); } }
        public static XPlaneCommand IceInletEai7On { get { return new XPlaneCommand("sim/ice/inlet_eai7_on", "Anti-ice: engine #8 anti-ice on."); } }
        public static XPlaneCommand IceInletEai0Off { get { return new XPlaneCommand("sim/ice/inlet_eai0_off", "Anti-ice: engine #1 anti-ice off."); } }
        public static XPlaneCommand IceInletEai1Off { get { return new XPlaneCommand("sim/ice/inlet_eai1_off", "Anti-ice: engine #2 anti-ice off."); } }
        public static XPlaneCommand IceInletEai2Off { get { return new XPlaneCommand("sim/ice/inlet_eai2_off", "Anti-ice: engine #3 anti-ice off."); } }
        public static XPlaneCommand IceInletEai3Off { get { return new XPlaneCommand("sim/ice/inlet_eai3_off", "Anti-ice: engine #4 anti-ice off."); } }
        public static XPlaneCommand IceInletEai4Off { get { return new XPlaneCommand("sim/ice/inlet_eai4_off", "Anti-ice: engine #5 anti-ice off."); } }
        public static XPlaneCommand IceInletEai5Off { get { return new XPlaneCommand("sim/ice/inlet_eai5_off", "Anti-ice: engine #6 anti-ice off."); } }
        public static XPlaneCommand IceInletEai6Off { get { return new XPlaneCommand("sim/ice/inlet_eai6_off", "Anti-ice: engine #7 anti-ice off."); } }
        public static XPlaneCommand IceInletEai7Off { get { return new XPlaneCommand("sim/ice/inlet_eai7_off", "Anti-ice: engine #8 anti-ice off."); } }
        public static XPlaneCommand IceInletEai0Tog { get { return new XPlaneCommand("sim/ice/inlet_eai0_tog", "Anti-ice: engine #1 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai1Tog { get { return new XPlaneCommand("sim/ice/inlet_eai1_tog", "Anti-ice: engine #2 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai2Tog { get { return new XPlaneCommand("sim/ice/inlet_eai2_tog", "Anti-ice: engine #3 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai3Tog { get { return new XPlaneCommand("sim/ice/inlet_eai3_tog", "Anti-ice: engine #4 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai4Tog { get { return new XPlaneCommand("sim/ice/inlet_eai4_tog", "Anti-ice: engine #5 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai5Tog { get { return new XPlaneCommand("sim/ice/inlet_eai5_tog", "Anti-ice: engine #6 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai6Tog { get { return new XPlaneCommand("sim/ice/inlet_eai6_tog", "Anti-ice: engine #7 anti-ice toggle."); } }
        public static XPlaneCommand IceInletEai7Tog { get { return new XPlaneCommand("sim/ice/inlet_eai7_tog", "Anti-ice: engine #8 anti-ice toggle."); } }
        public static XPlaneCommand IcePropHeatOn { get { return new XPlaneCommand("sim/ice/prop_heat_on", "Anti-ice: all prop heat on."); } }
        public static XPlaneCommand IcePropHeatOff { get { return new XPlaneCommand("sim/ice/prop_heat_off", "Anti-ice: all prop heat off."); } }
        public static XPlaneCommand IcePropHeatTog { get { return new XPlaneCommand("sim/ice/prop_heat_tog", "Anti-ice: all prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat0On { get { return new XPlaneCommand("sim/ice/prop_heat0_on", "Anti-ice: engine #1 prop heat on."); } }
        public static XPlaneCommand IcePropHeat1On { get { return new XPlaneCommand("sim/ice/prop_heat1_on", "Anti-ice: engine #2 prop heat on."); } }
        public static XPlaneCommand IcePropHeat2On { get { return new XPlaneCommand("sim/ice/prop_heat2_on", "Anti-ice: engine #3 prop heat on."); } }
        public static XPlaneCommand IcePropHeat3On { get { return new XPlaneCommand("sim/ice/prop_heat3_on", "Anti-ice: engine #4 prop heat on."); } }
        public static XPlaneCommand IcePropHeat4On { get { return new XPlaneCommand("sim/ice/prop_heat4_on", "Anti-ice: engine #5 prop heat on."); } }
        public static XPlaneCommand IcePropHeat5On { get { return new XPlaneCommand("sim/ice/prop_heat5_on", "Anti-ice: engine #6 prop heat on."); } }
        public static XPlaneCommand IcePropHeat6On { get { return new XPlaneCommand("sim/ice/prop_heat6_on", "Anti-ice: engine #7 prop heat on."); } }
        public static XPlaneCommand IcePropHeat7On { get { return new XPlaneCommand("sim/ice/prop_heat7_on", "Anti-ice: engine #8 prop heat on."); } }
        public static XPlaneCommand IcePropHeat0Off { get { return new XPlaneCommand("sim/ice/prop_heat0_off", "Anti-ice: engine #1 prop heat off."); } }
        public static XPlaneCommand IcePropHeat1Off { get { return new XPlaneCommand("sim/ice/prop_heat1_off", "Anti-ice: engine #2 prop heat off."); } }
        public static XPlaneCommand IcePropHeat2Off { get { return new XPlaneCommand("sim/ice/prop_heat2_off", "Anti-ice: engine #3 prop heat off."); } }
        public static XPlaneCommand IcePropHeat3Off { get { return new XPlaneCommand("sim/ice/prop_heat3_off", "Anti-ice: engine #4 prop heat off."); } }
        public static XPlaneCommand IcePropHeat4Off { get { return new XPlaneCommand("sim/ice/prop_heat4_off", "Anti-ice: engine #5 prop heat off."); } }
        public static XPlaneCommand IcePropHeat5Off { get { return new XPlaneCommand("sim/ice/prop_heat5_off", "Anti-ice: engine #6 prop heat off."); } }
        public static XPlaneCommand IcePropHeat6Off { get { return new XPlaneCommand("sim/ice/prop_heat6_off", "Anti-ice: engine #7 prop heat off."); } }
        public static XPlaneCommand IcePropHeat7Off { get { return new XPlaneCommand("sim/ice/prop_heat7_off", "Anti-ice: engine #8 prop heat off."); } }
        public static XPlaneCommand IcePropHeat0Tog { get { return new XPlaneCommand("sim/ice/prop_heat0_tog", "Anti-ice: engine #1 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat1Tog { get { return new XPlaneCommand("sim/ice/prop_heat1_tog", "Anti-ice: engine #2 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat2Tog { get { return new XPlaneCommand("sim/ice/prop_heat2_tog", "Anti-ice: engine #3 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat3Tog { get { return new XPlaneCommand("sim/ice/prop_heat3_tog", "Anti-ice: engine #4 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat4Tog { get { return new XPlaneCommand("sim/ice/prop_heat4_tog", "Anti-ice: engine #5 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat5Tog { get { return new XPlaneCommand("sim/ice/prop_heat5_tog", "Anti-ice: engine #6 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat6Tog { get { return new XPlaneCommand("sim/ice/prop_heat6_tog", "Anti-ice: engine #7 prop heat toggle."); } }
        public static XPlaneCommand IcePropHeat7Tog { get { return new XPlaneCommand("sim/ice/prop_heat7_tog", "Anti-ice: engine #8 prop heat toggle."); } }
        public static XPlaneCommand IcePropTksOn { get { return new XPlaneCommand("sim/ice/prop_tks_on", "Anti-ice: all prop TKS norm."); } }
        public static XPlaneCommand IcePropTksHigh { get { return new XPlaneCommand("sim/ice/prop_tks_high", "Anti-ice: all prop TKS high."); } }
        public static XPlaneCommand IcePropTksOff { get { return new XPlaneCommand("sim/ice/prop_tks_off", "Anti-ice: all prop TKS off."); } }
        public static XPlaneCommand IcePropTksTog { get { return new XPlaneCommand("sim/ice/prop_tks_tog", "Anti-ice: all prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks0On { get { return new XPlaneCommand("sim/ice/prop_tks0_on", "Anti-ice: engine #1 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks1On { get { return new XPlaneCommand("sim/ice/prop_tks1_on", "Anti-ice: engine #2 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks2On { get { return new XPlaneCommand("sim/ice/prop_tks2_on", "Anti-ice: engine #3 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks3On { get { return new XPlaneCommand("sim/ice/prop_tks3_on", "Anti-ice: engine #4 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks4On { get { return new XPlaneCommand("sim/ice/prop_tks4_on", "Anti-ice: engine #5 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks5On { get { return new XPlaneCommand("sim/ice/prop_tks5_on", "Anti-ice: engine #6 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks6On { get { return new XPlaneCommand("sim/ice/prop_tks6_on", "Anti-ice: engine #7 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks7On { get { return new XPlaneCommand("sim/ice/prop_tks7_on", "Anti-ice: engine #8 prop TKS norm."); } }
        public static XPlaneCommand IcePropTks0High { get { return new XPlaneCommand("sim/ice/prop_tks0_high", "Anti-ice: engine #1 prop TKS high."); } }
        public static XPlaneCommand IcePropTks1High { get { return new XPlaneCommand("sim/ice/prop_tks1_high", "Anti-ice: engine #2 prop TKS high."); } }
        public static XPlaneCommand IcePropTks2High { get { return new XPlaneCommand("sim/ice/prop_tks2_high", "Anti-ice: engine #3 prop TKS high."); } }
        public static XPlaneCommand IcePropTks3High { get { return new XPlaneCommand("sim/ice/prop_tks3_high", "Anti-ice: engine #4 prop TKS high."); } }
        public static XPlaneCommand IcePropTks4High { get { return new XPlaneCommand("sim/ice/prop_tks4_high", "Anti-ice: engine #5 prop TKS high."); } }
        public static XPlaneCommand IcePropTks5High { get { return new XPlaneCommand("sim/ice/prop_tks5_high", "Anti-ice: engine #6 prop TKS high."); } }
        public static XPlaneCommand IcePropTks6High { get { return new XPlaneCommand("sim/ice/prop_tks6_high", "Anti-ice: engine #7 prop TKS high."); } }
        public static XPlaneCommand IcePropTks7High { get { return new XPlaneCommand("sim/ice/prop_tks7_high", "Anti-ice: engine #8 prop TKS high."); } }
        public static XPlaneCommand IcePropTks0Off { get { return new XPlaneCommand("sim/ice/prop_tks0_off", "Anti-ice: engine #1 prop TKS off."); } }
        public static XPlaneCommand IcePropTks1Off { get { return new XPlaneCommand("sim/ice/prop_tks1_off", "Anti-ice: engine #2 prop TKS off."); } }
        public static XPlaneCommand IcePropTks2Off { get { return new XPlaneCommand("sim/ice/prop_tks2_off", "Anti-ice: engine #3 prop TKS off."); } }
        public static XPlaneCommand IcePropTks3Off { get { return new XPlaneCommand("sim/ice/prop_tks3_off", "Anti-ice: engine #4 prop TKS off."); } }
        public static XPlaneCommand IcePropTks4Off { get { return new XPlaneCommand("sim/ice/prop_tks4_off", "Anti-ice: engine #5 prop TKS off."); } }
        public static XPlaneCommand IcePropTks5Off { get { return new XPlaneCommand("sim/ice/prop_tks5_off", "Anti-ice: engine #6 prop TKS off."); } }
        public static XPlaneCommand IcePropTks6Off { get { return new XPlaneCommand("sim/ice/prop_tks6_off", "Anti-ice: engine #7 prop TKS off."); } }
        public static XPlaneCommand IcePropTks7Off { get { return new XPlaneCommand("sim/ice/prop_tks7_off", "Anti-ice: engine #8 prop TKS off."); } }
        public static XPlaneCommand IcePropTks0Tog { get { return new XPlaneCommand("sim/ice/prop_tks0_tog", "Anti-ice: engine #1 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks1Tog { get { return new XPlaneCommand("sim/ice/prop_tks1_tog", "Anti-ice: engine #2 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks2Tog { get { return new XPlaneCommand("sim/ice/prop_tks2_tog", "Anti-ice: engine #3 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks3Tog { get { return new XPlaneCommand("sim/ice/prop_tks3_tog", "Anti-ice: engine #4 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks4Tog { get { return new XPlaneCommand("sim/ice/prop_tks4_tog", "Anti-ice: engine #5 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks5Tog { get { return new XPlaneCommand("sim/ice/prop_tks5_tog", "Anti-ice: engine #6 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks6Tog { get { return new XPlaneCommand("sim/ice/prop_tks6_tog", "Anti-ice: engine #7 prop TKS toggle."); } }
        public static XPlaneCommand IcePropTks7Tog { get { return new XPlaneCommand("sim/ice/prop_tks7_tog", "Anti-ice: engine #8 prop TKS toggle."); } }
        public static XPlaneCommand IceDetectOn { get { return new XPlaneCommand("sim/ice/detect_on", "Anti-ice: ice detection on."); } }
        public static XPlaneCommand IceDetectOff { get { return new XPlaneCommand("sim/ice/detect_off", "Anti-ice: ice detection off."); } }
        public static XPlaneCommand OxyCrewValveOn { get { return new XPlaneCommand("sim/oxy/crew_valve_on", "Crew oxygen: master valve open/on."); } }
        public static XPlaneCommand OxyCrewValveOff { get { return new XPlaneCommand("sim/oxy/crew_valve_off", "Crew oxygen: master valve closed/off."); } }
        public static XPlaneCommand OxyCrewValveToggle { get { return new XPlaneCommand("sim/oxy/crew_valve_toggle", "Crew oxygen: master valve toggle"); } }
        public static XPlaneCommand OxyCrewRegulatorUp { get { return new XPlaneCommand("sim/oxy/crew_regulator_up", "Crew oxygen: demand regulator up."); } }
        public static XPlaneCommand OxyCrewRegulatorDown { get { return new XPlaneCommand("sim/oxy/crew_regulator_down", "Crew oxygen: demand regulator down."); } }
        public static XPlaneCommand OxyPassengerO2On { get { return new XPlaneCommand("sim/oxy/passenger_o2_on", "Passenger oxygen: drop masks."); } }
        public static XPlaneCommand FlightControlsParachuteFlares { get { return new XPlaneCommand("sim/flight_controls/parachute_flares", "Deploy parachute flares."); } }
        public static XPlaneCommand FlightControlsSmokeToggle { get { return new XPlaneCommand("sim/flight_controls/smoke_toggle", "Toggle smoke puffing."); } }
        public static XPlaneCommand FlightControlsWaterScoopToggle { get { return new XPlaneCommand("sim/flight_controls/water_scoop_toggle", "Toggle water scoop."); } }
        public static XPlaneCommand FlightControlsBoost { get { return new XPlaneCommand("sim/flight_controls/boost", "Water or Nitrous engine BOOST."); } }
        public static XPlaneCommand FlightControlsIgniteJato { get { return new XPlaneCommand("sim/flight_controls/ignite_jato", "Ignite JATO."); } }
        public static XPlaneCommand FlightControlsJettisonPayload { get { return new XPlaneCommand("sim/flight_controls/jettison_payload", "Jettison the payload."); } }
        public static XPlaneCommand FlightControlsDumpFuelOn { get { return new XPlaneCommand("sim/flight_controls/dump_fuel_on", "Dump fuel on."); } }
        public static XPlaneCommand FlightControlsDumpFuelOff { get { return new XPlaneCommand("sim/flight_controls/dump_fuel_off", "Dump fuel off."); } }
        public static XPlaneCommand FlightControlsDumpFuelToggle { get { return new XPlaneCommand("sim/flight_controls/dump_fuel_toggle", "Dump fuel toggle."); } }
        public static XPlaneCommand FlightControlsDeployParachute { get { return new XPlaneCommand("sim/flight_controls/deploy_parachute", "Deploy/jettison chute."); } }
        public static XPlaneCommand FlightControlsEject { get { return new XPlaneCommand("sim/flight_controls/eject", "Eject."); } }
        public static XPlaneCommand FlightControlsDropTank { get { return new XPlaneCommand("sim/flight_controls/drop_tank", "Drop all drop tanks."); } }
        public static XPlaneCommand WeaponsReArmAircraft { get { return new XPlaneCommand("sim/weapons/re_arm_aircraft", "Re-arm aircraft to default specs."); } }
        public static XPlaneCommand WeaponsMasterArmOn { get { return new XPlaneCommand("sim/weapons/master_arm_on", "Master arm on."); } }
        public static XPlaneCommand WeaponsMasterArmOff { get { return new XPlaneCommand("sim/weapons/master_arm_off", "Master arm off."); } }
        public static XPlaneCommand WeaponsFireModeDown { get { return new XPlaneCommand("sim/weapons/fire_mode_down", "Weapon single/pair/ripple/salvo down."); } }
        public static XPlaneCommand WeaponsFireModeUp { get { return new XPlaneCommand("sim/weapons/fire_mode_up", "Weapon single/pair/ripple/salvo up."); } }
        public static XPlaneCommand WeaponsFireRateDown { get { return new XPlaneCommand("sim/weapons/fire_rate_down", "Weapon fire rate down."); } }
        public static XPlaneCommand WeaponsFireRateUp { get { return new XPlaneCommand("sim/weapons/fire_rate_up", "Weapon fire rate up."); } }
        public static XPlaneCommand WeaponsWeaponSelectDown { get { return new XPlaneCommand("sim/weapons/weapon_select_down", "Weapon select down."); } }
        public static XPlaneCommand WeaponsWeaponSelectUp { get { return new XPlaneCommand("sim/weapons/weapon_select_up", "Weapon select up."); } }
        public static XPlaneCommand WeaponsFireGuns { get { return new XPlaneCommand("sim/weapons/fire_guns", "Fire guns."); } }
        public static XPlaneCommand WeaponsFireAirToAir { get { return new XPlaneCommand("sim/weapons/fire_air_to_air", "Fire air-to-air selection."); } }
        public static XPlaneCommand WeaponsFireAirToGround { get { return new XPlaneCommand("sim/weapons/fire_air_to_ground", "Fire air-to-ground selection."); } }
        public static XPlaneCommand WeaponsFireAnyArmed { get { return new XPlaneCommand("sim/weapons/fire_any_armed", "Fire all armed selections."); } }
        public static XPlaneCommand WeaponsFireAnyShell { get { return new XPlaneCommand("sim/weapons/fire_any_shell", "Fire selected weapon."); } }
        public static XPlaneCommand WeaponsGPSLockHere { get { return new XPlaneCommand("sim/weapons/GPS_lock_here", "Target camera pointer in GPS."); } }
        public static XPlaneCommand WeaponsWeaponTargetDown { get { return new XPlaneCommand("sim/weapons/weapon_target_down", "Target select down."); } }
        public static XPlaneCommand WeaponsWeaponTargetUp { get { return new XPlaneCommand("sim/weapons/weapon_target_up", "Target select up."); } }
        public static XPlaneCommand WeaponsDeployChaff { get { return new XPlaneCommand("sim/weapons/deploy_chaff", "Deploy chaff."); } }
        public static XPlaneCommand WeaponsDeployFlares { get { return new XPlaneCommand("sim/weapons/deploy_flares", "Deploy flares."); } }
        public static XPlaneCommand OperationPrevLivery { get { return new XPlaneCommand("sim/operation/prev_livery", "Load previous livery."); } }
        public static XPlaneCommand OperationNextLivery { get { return new XPlaneCommand("sim/operation/next_livery", "Load next livery."); } }
        public static XPlaneCommand SystemsSeatbeltSignToggle { get { return new XPlaneCommand("sim/systems/seatbelt_sign_toggle", "Toggle seatbelt sign."); } }
        public static XPlaneCommand SystemsNoSmokingToggle { get { return new XPlaneCommand("sim/systems/no_smoking_toggle", "Toggle smoking sign."); } }
        public static XPlaneCommand SystemsWipersDn { get { return new XPlaneCommand("sim/systems/wipers_dn", "Windshield wipers down."); } }
        public static XPlaneCommand SystemsWipersUp { get { return new XPlaneCommand("sim/systems/wipers_up", "Windshield wipers up."); } }
        public static XPlaneCommand LightsSpotLightLeft { get { return new XPlaneCommand("sim/lights/spot_light_left", "Aim spotlight left."); } }
        public static XPlaneCommand LightsSpotLightRight { get { return new XPlaneCommand("sim/lights/spot_light_right", "Aim spotlight right."); } }
        public static XPlaneCommand LightsSpotLightUp { get { return new XPlaneCommand("sim/lights/spot_light_up", "Aim spotlight up."); } }
        public static XPlaneCommand LightsSpotLightDown { get { return new XPlaneCommand("sim/lights/spot_light_down", "Aim spotlight down."); } }
        public static XPlaneCommand LightsSpotLightCenter { get { return new XPlaneCommand("sim/lights/spot_light_center", "Aim spotlight to center."); } }
        public static XPlaneCommand FlightControlsDoorOpen1 { get { return new XPlaneCommand("sim/flight_controls/door_open_1", "Door #1 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen2 { get { return new XPlaneCommand("sim/flight_controls/door_open_2", "Door #2 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen3 { get { return new XPlaneCommand("sim/flight_controls/door_open_3", "Door #3 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen4 { get { return new XPlaneCommand("sim/flight_controls/door_open_4", "Door #4 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen5 { get { return new XPlaneCommand("sim/flight_controls/door_open_5", "Door #5 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen6 { get { return new XPlaneCommand("sim/flight_controls/door_open_6", "Door #6 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen7 { get { return new XPlaneCommand("sim/flight_controls/door_open_7", "Door #7 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen8 { get { return new XPlaneCommand("sim/flight_controls/door_open_8", "Door #8 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen9 { get { return new XPlaneCommand("sim/flight_controls/door_open_9", "Door #9 open."); } }
        public static XPlaneCommand FlightControlsDoorOpen10 { get { return new XPlaneCommand("sim/flight_controls/door_open_10", "Door #10 open."); } }
        public static XPlaneCommand FlightControlsDoorClose1 { get { return new XPlaneCommand("sim/flight_controls/door_close_1", "Door #1 close."); } }
        public static XPlaneCommand FlightControlsDoorClose2 { get { return new XPlaneCommand("sim/flight_controls/door_close_2", "Door #2 close."); } }
        public static XPlaneCommand FlightControlsDoorClose3 { get { return new XPlaneCommand("sim/flight_controls/door_close_3", "Door #3 close."); } }
        public static XPlaneCommand FlightControlsDoorClose4 { get { return new XPlaneCommand("sim/flight_controls/door_close_4", "Door #4 close."); } }
        public static XPlaneCommand FlightControlsDoorClose5 { get { return new XPlaneCommand("sim/flight_controls/door_close_5", "Door #5 close."); } }
        public static XPlaneCommand FlightControlsDoorClose6 { get { return new XPlaneCommand("sim/flight_controls/door_close_6", "Door #6 close."); } }
        public static XPlaneCommand FlightControlsDoorClose7 { get { return new XPlaneCommand("sim/flight_controls/door_close_7", "Door #7 close."); } }
        public static XPlaneCommand FlightControlsDoorClose8 { get { return new XPlaneCommand("sim/flight_controls/door_close_8", "Door #8 close."); } }
        public static XPlaneCommand FlightControlsDoorClose9 { get { return new XPlaneCommand("sim/flight_controls/door_close_9", "Door #9 close."); } }
        public static XPlaneCommand FlightControlsDoorClose10 { get { return new XPlaneCommand("sim/flight_controls/door_close_10", "Door #10 close."); } }
        public static XPlaneCommand GeneralAction { get { return new XPlaneCommand("sim/general/action", "General action command."); } }
        public static XPlaneCommand FlightControlsGliderTowRelease { get { return new XPlaneCommand("sim/flight_controls/glider_tow_release", "Release tow-plane cable for gliders."); } }
        public static XPlaneCommand FlightControlsWinchRelease { get { return new XPlaneCommand("sim/flight_controls/winch_release", "Release winch (for gliders)."); } }
        public static XPlaneCommand FlightControlsGliderAllRelease { get { return new XPlaneCommand("sim/flight_controls/glider_all_release", "Release tow-plane and winch for gliders."); } }
        public static XPlaneCommand FlightControlsEngageCatShot { get { return new XPlaneCommand("sim/flight_controls/engage_cat_shot", "Engage catapault."); } }
        public static XPlaneCommand FlightControlsGliderTowLeft { get { return new XPlaneCommand("sim/flight_controls/glider_tow_left", "Tow-plane for gliders: Take me left."); } }
        public static XPlaneCommand FlightControlsGliderTowStraight { get { return new XPlaneCommand("sim/flight_controls/glider_tow_straight", "Tow-plane for gliders: Take me straight."); } }
        public static XPlaneCommand FlightControlsGliderTowRight { get { return new XPlaneCommand("sim/flight_controls/glider_tow_right", "Tow-plane for gliders: Take me right."); } }
        public static XPlaneCommand FlightControlsWinchFaster { get { return new XPlaneCommand("sim/flight_controls/winch_faster", "Winch faster. (for gliders)."); } }
        public static XPlaneCommand FlightControlsWinchSlower { get { return new XPlaneCommand("sim/flight_controls/winch_slower", "Winch slower. (for gliders)."); } }
        public static XPlaneCommand GroundOpsServicePlane { get { return new XPlaneCommand("sim/ground_ops/service_plane", "Service the airplane with ground trucks."); } }
        public static XPlaneCommand GroundOpsPushbackLeft { get { return new XPlaneCommand("sim/ground_ops/pushback_left", "Push-back for airliners: Nose 90 left."); } }
        public static XPlaneCommand GroundOpsPushbackStraight { get { return new XPlaneCommand("sim/ground_ops/pushback_straight", "Push-back for airliners: Straight back."); } }
        public static XPlaneCommand GroundOpsPushbackRight { get { return new XPlaneCommand("sim/ground_ops/pushback_right", "Push-back for airliners: Nose 90 right."); } }
        public static XPlaneCommand GroundOpsPushbackStop { get { return new XPlaneCommand("sim/ground_ops/pushback_stop", "Push-back for airliners: Stop and let go."); } }
        public static XPlaneCommand GroundOpsToggleWindow { get { return new XPlaneCommand("sim/ground_ops/toggle_window", "Toggle the ground handling window."); } }
        public static XPlaneCommand RadiosPowerNav1Off { get { return new XPlaneCommand("sim/radios/power_nav1_off", "Power NAV1 off."); } }
        public static XPlaneCommand RadiosPowerNav1On { get { return new XPlaneCommand("sim/radios/power_nav1_on", "Power NAV1 on."); } }
        public static XPlaneCommand RadiosPowerNav2Off { get { return new XPlaneCommand("sim/radios/power_nav2_off", "Power NAV2 off."); } }
        public static XPlaneCommand RadiosPowerNav2On { get { return new XPlaneCommand("sim/radios/power_nav2_on", "Power NAV2 on."); } }
        public static XPlaneCommand RadiosPowerCom1Off { get { return new XPlaneCommand("sim/radios/power_com1_off", "Power COM1 off."); } }
        public static XPlaneCommand RadiosPowerCom1On { get { return new XPlaneCommand("sim/radios/power_com1_on", "Power COM1 on."); } }
        public static XPlaneCommand RadiosPowerCom2Off { get { return new XPlaneCommand("sim/radios/power_com2_off", "Power COM2 off."); } }
        public static XPlaneCommand RadiosPowerCom2On { get { return new XPlaneCommand("sim/radios/power_com2_on", "Power COM2 on."); } }
        public static XPlaneCommand RadiosPowerAdf1Dn { get { return new XPlaneCommand("sim/radios/power_adf1_dn", "Power ADF1 dn."); } }
        public static XPlaneCommand RadiosPowerAdf1Up { get { return new XPlaneCommand("sim/radios/power_adf1_up", "Power ADF1 up."); } }
        public static XPlaneCommand RadiosPowerAdf2Dn { get { return new XPlaneCommand("sim/radios/power_adf2_dn", "Power ADF2 dn."); } }
        public static XPlaneCommand RadiosPowerAdf2Up { get { return new XPlaneCommand("sim/radios/power_adf2_up", "Power ADF2 up."); } }
        public static XPlaneCommand RadiosAdf1PowerMode0 { get { return new XPlaneCommand("sim/radios/adf1_power_mode_0", "ADF 1 off."); } }
        public static XPlaneCommand RadiosAdf1PowerMode1 { get { return new XPlaneCommand("sim/radios/adf1_power_mode_1", "ADF 1 antenna."); } }
        public static XPlaneCommand RadiosAdf1PowerMode2 { get { return new XPlaneCommand("sim/radios/adf1_power_mode_2", "ADF 1 on."); } }
        public static XPlaneCommand RadiosAdf1PowerMode3 { get { return new XPlaneCommand("sim/radios/adf1_power_mode_3", "ADF 1 tone."); } }
        public static XPlaneCommand RadiosAdf1PowerMode4 { get { return new XPlaneCommand("sim/radios/adf1_power_mode_4", "ADF 1 test."); } }
        public static XPlaneCommand RadiosAdf2PowerMode0 { get { return new XPlaneCommand("sim/radios/adf2_power_mode_0", "ADF 2 off."); } }
        public static XPlaneCommand RadiosAdf2PowerMode1 { get { return new XPlaneCommand("sim/radios/adf2_power_mode_1", "ADF 2 antenna."); } }
        public static XPlaneCommand RadiosAdf2PowerMode2 { get { return new XPlaneCommand("sim/radios/adf2_power_mode_2", "ADF 2 on."); } }
        public static XPlaneCommand RadiosAdf2PowerMode3 { get { return new XPlaneCommand("sim/radios/adf2_power_mode_3", "ADF 2 tone."); } }
        public static XPlaneCommand RadiosAdf2PowerMode4 { get { return new XPlaneCommand("sim/radios/adf2_power_mode_4", "ADF 2 test."); } }
        public static XPlaneCommand RadiosActvCom1CoarseDown { get { return new XPlaneCommand("sim/radios/actv_com1_coarse_down", "COM 1 coarse down."); } }
        public static XPlaneCommand RadiosActvCom1CoarseUp { get { return new XPlaneCommand("sim/radios/actv_com1_coarse_up", "COM 1 coarse up."); } }
        public static XPlaneCommand RadiosActvCom1FineDown { get { return new XPlaneCommand("sim/radios/actv_com1_fine_down", "COM 1 fine down (25kHz)."); } }
        public static XPlaneCommand RadiosActvCom1FineUp { get { return new XPlaneCommand("sim/radios/actv_com1_fine_up", "COM 1 fine up (25kHz)."); } }
        public static XPlaneCommand RadiosActvCom1CoarseDown833 { get { return new XPlaneCommand("sim/radios/actv_com1_coarse_down_833", "COM 1 coarse down (8.33 kHz)."); } }
        public static XPlaneCommand RadiosActvCom1CoarseUp833 { get { return new XPlaneCommand("sim/radios/actv_com1_coarse_up_833", "COM 1 coarse up (8.33 kHz)."); } }
        public static XPlaneCommand RadiosActvCom1FineDown833 { get { return new XPlaneCommand("sim/radios/actv_com1_fine_down_833", "COM 1 fine down (8.33 kHz)."); } }
        public static XPlaneCommand RadiosActvCom1FineUp833 { get { return new XPlaneCommand("sim/radios/actv_com1_fine_up_833", "COM 1 fine up (8.33 kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1CoarseDown { get { return new XPlaneCommand("sim/radios/stby_com1_coarse_down", "COM 1 standby coarse down."); } }
        public static XPlaneCommand RadiosStbyCom1CoarseUp { get { return new XPlaneCommand("sim/radios/stby_com1_coarse_up", "COM 1 standby coarse up."); } }
        public static XPlaneCommand RadiosStbyCom1FineDown { get { return new XPlaneCommand("sim/radios/stby_com1_fine_down", "COM 1 standby fine down (25kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1FineUp { get { return new XPlaneCommand("sim/radios/stby_com1_fine_up", "COM 1 standby fine up (25kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1CoarseDown833 { get { return new XPlaneCommand("sim/radios/stby_com1_coarse_down_833", "COM 1 standby coarse down (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1CoarseUp833 { get { return new XPlaneCommand("sim/radios/stby_com1_coarse_up_833", "COM 1 standby coarse up (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1FineDown833 { get { return new XPlaneCommand("sim/radios/stby_com1_fine_down_833", "COM 1 standby fine down (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom1FineUp833 { get { return new XPlaneCommand("sim/radios/stby_com1_fine_up_833", "COM 1 standby fine up (8.33kHz)."); } }
        public static XPlaneCommand RadiosActvCom2CoarseDown { get { return new XPlaneCommand("sim/radios/actv_com2_coarse_down", "COM 2 coarse down."); } }
        public static XPlaneCommand RadiosActvCom2CoarseUp { get { return new XPlaneCommand("sim/radios/actv_com2_coarse_up", "COM 2 coarse up."); } }
        public static XPlaneCommand RadiosActvCom2FineDown { get { return new XPlaneCommand("sim/radios/actv_com2_fine_down", "COM 2 fine down (25kHz)."); } }
        public static XPlaneCommand RadiosActvCom2FineUp { get { return new XPlaneCommand("sim/radios/actv_com2_fine_up", "COM 2 fine up (25kHz)."); } }
        public static XPlaneCommand RadiosActvCom2CoarseDown833 { get { return new XPlaneCommand("sim/radios/actv_com2_coarse_down_833", "COM 2 coarse down (8.33kHz)."); } }
        public static XPlaneCommand RadiosActvCom2CoarseUp833 { get { return new XPlaneCommand("sim/radios/actv_com2_coarse_up_833", "COM 2 coarse up (8.33kHz)."); } }
        public static XPlaneCommand RadiosActvCom2FineDown833 { get { return new XPlaneCommand("sim/radios/actv_com2_fine_down_833", "COM 2 fine down (8.33kHz)."); } }
        public static XPlaneCommand RadiosActvCom2FineUp833 { get { return new XPlaneCommand("sim/radios/actv_com2_fine_up_833", "COM 2 fine up (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2CoarseDown { get { return new XPlaneCommand("sim/radios/stby_com2_coarse_down", "COM 2 standby coarse down."); } }
        public static XPlaneCommand RadiosStbyCom2CoarseUp { get { return new XPlaneCommand("sim/radios/stby_com2_coarse_up", "COM 2 standby coarse up."); } }
        public static XPlaneCommand RadiosStbyCom2FineDown { get { return new XPlaneCommand("sim/radios/stby_com2_fine_down", "COM 2 standby fine down (25kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2FineUp { get { return new XPlaneCommand("sim/radios/stby_com2_fine_up", "COM 2 standby fine up (25kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2CoarseDown833 { get { return new XPlaneCommand("sim/radios/stby_com2_coarse_down_833", "COM 2 standby coarse down (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2CoarseUp833 { get { return new XPlaneCommand("sim/radios/stby_com2_coarse_up_833", "COM 2 standby coarse up (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2FineDown833 { get { return new XPlaneCommand("sim/radios/stby_com2_fine_down_833", "COM 2 standby fine down (8.33kHz)."); } }
        public static XPlaneCommand RadiosStbyCom2FineUp833 { get { return new XPlaneCommand("sim/radios/stby_com2_fine_up_833", "COM 2 standby fine up (8.33kHz)."); } }
        public static XPlaneCommand RadiosActvNav1CoarseDown { get { return new XPlaneCommand("sim/radios/actv_nav1_coarse_down", "NAV 1 coarse down."); } }
        public static XPlaneCommand RadiosActvNav1CoarseUp { get { return new XPlaneCommand("sim/radios/actv_nav1_coarse_up", "NAV 1 coarse up."); } }
        public static XPlaneCommand RadiosActvNav1FineDown { get { return new XPlaneCommand("sim/radios/actv_nav1_fine_down", "NAV 1 fine down."); } }
        public static XPlaneCommand RadiosActvNav1FineUp { get { return new XPlaneCommand("sim/radios/actv_nav1_fine_up", "NAV 1 fine up."); } }
        public static XPlaneCommand RadiosStbyNav1CoarseDown { get { return new XPlaneCommand("sim/radios/stby_nav1_coarse_down", "NAV 1 standby coarse down."); } }
        public static XPlaneCommand RadiosStbyNav1CoarseUp { get { return new XPlaneCommand("sim/radios/stby_nav1_coarse_up", "NAV 1 standby coarse up."); } }
        public static XPlaneCommand RadiosStbyNav1FineDown { get { return new XPlaneCommand("sim/radios/stby_nav1_fine_down", "NAV 1 standby fine down."); } }
        public static XPlaneCommand RadiosStbyNav1FineUp { get { return new XPlaneCommand("sim/radios/stby_nav1_fine_up", "NAV 1 standby fine up."); } }
        public static XPlaneCommand RadiosActvNav2CoarseDown { get { return new XPlaneCommand("sim/radios/actv_nav2_coarse_down", "NAV 2 coarse down."); } }
        public static XPlaneCommand RadiosActvNav2CoarseUp { get { return new XPlaneCommand("sim/radios/actv_nav2_coarse_up", "NAV 2 coarse up."); } }
        public static XPlaneCommand RadiosActvNav2FineDown { get { return new XPlaneCommand("sim/radios/actv_nav2_fine_down", "NAV 2 fine down."); } }
        public static XPlaneCommand RadiosActvNav2FineUp { get { return new XPlaneCommand("sim/radios/actv_nav2_fine_up", "NAV 2 fine up."); } }
        public static XPlaneCommand RadiosStbyNav2CoarseDown { get { return new XPlaneCommand("sim/radios/stby_nav2_coarse_down", "NAV 2 standby coarse down."); } }
        public static XPlaneCommand RadiosStbyNav2CoarseUp { get { return new XPlaneCommand("sim/radios/stby_nav2_coarse_up", "NAV 2 standby coarse up."); } }
        public static XPlaneCommand RadiosStbyNav2FineDown { get { return new XPlaneCommand("sim/radios/stby_nav2_fine_down", "NAV 2 standby fine down."); } }
        public static XPlaneCommand RadiosStbyNav2FineUp { get { return new XPlaneCommand("sim/radios/stby_nav2_fine_up", "NAV 2 standby fine up."); } }
        public static XPlaneCommand RadiosActvDmeCoarseDown { get { return new XPlaneCommand("sim/radios/actv_dme_coarse_down", "DME coarse down."); } }
        public static XPlaneCommand RadiosActvDmeCoarseUp { get { return new XPlaneCommand("sim/radios/actv_dme_coarse_up", "DME coarse up."); } }
        public static XPlaneCommand RadiosActvDmeFineDown { get { return new XPlaneCommand("sim/radios/actv_dme_fine_down", "DME fine down."); } }
        public static XPlaneCommand RadiosActvDmeFineUp { get { return new XPlaneCommand("sim/radios/actv_dme_fine_up", "DME fine up."); } }
        public static XPlaneCommand RadiosStbyDmeCoarseDown { get { return new XPlaneCommand("sim/radios/stby_dme_coarse_down", "DME standby coarse down."); } }
        public static XPlaneCommand RadiosStbyDmeCoarseUp { get { return new XPlaneCommand("sim/radios/stby_dme_coarse_up", "DME standby coarse up."); } }
        public static XPlaneCommand RadiosStbyDmeFineDown { get { return new XPlaneCommand("sim/radios/stby_dme_fine_down", "DME standby fine down."); } }
        public static XPlaneCommand RadiosStbyDmeFineUp { get { return new XPlaneCommand("sim/radios/stby_dme_fine_up", "DME standby fine up."); } }
        public static XPlaneCommand RadiosActvAdf1HundredsDown { get { return new XPlaneCommand("sim/radios/actv_adf1_hundreds_down", "ADF active 1 hundreds down."); } }
        public static XPlaneCommand RadiosActvAdf1HundredsUp { get { return new XPlaneCommand("sim/radios/actv_adf1_hundreds_up", "ADF active 1 hundreds up."); } }
        public static XPlaneCommand RadiosActvAdf1TensDown { get { return new XPlaneCommand("sim/radios/actv_adf1_tens_down", "ADF active 1 tens down."); } }
        public static XPlaneCommand RadiosActvAdf1TensUp { get { return new XPlaneCommand("sim/radios/actv_adf1_tens_up", "ADF active 1 tens up."); } }
        public static XPlaneCommand RadiosActvAdf1OnesDown { get { return new XPlaneCommand("sim/radios/actv_adf1_ones_down", "ADF active 1 ones down."); } }
        public static XPlaneCommand RadiosActvAdf1OnesUp { get { return new XPlaneCommand("sim/radios/actv_adf1_ones_up", "ADF active 1 ones up."); } }
        public static XPlaneCommand RadiosActvAdf1OnesTensDown { get { return new XPlaneCommand("sim/radios/actv_adf1_ones_tens_down", "ADF active 1 ones and tens down."); } }
        public static XPlaneCommand RadiosActvAdf1OnesTensUp { get { return new XPlaneCommand("sim/radios/actv_adf1_ones_tens_up", "ADF active 1 ones and tens up."); } }
        public static XPlaneCommand RadiosActvAdf1HundredsThousDown { get { return new XPlaneCommand("sim/radios/actv_adf1_hundreds_thous_down", "ADF active 1 hundreds and thousands down."); } }
        public static XPlaneCommand RadiosActvAdf1HundredsThousUp { get { return new XPlaneCommand("sim/radios/actv_adf1_hundreds_thous_up", "ADF active 1 hundreds and thousands up."); } }
        public static XPlaneCommand RadiosActvAdf14DigHundredsDown { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_hundreds_down", "4-digit ADF active 1 hundreds down."); } }
        public static XPlaneCommand RadiosActvAdf14DigHundredsUp { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_hundreds_up", "4-digit ADF active 1 hundreds up."); } }
        public static XPlaneCommand RadiosActvAdf14DigTensDown { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_tens_down", "4-digit ADF active 1 tens down."); } }
        public static XPlaneCommand RadiosActvAdf14DigTensUp { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_tens_up", "4-digit ADF active 1 tens up."); } }
        public static XPlaneCommand RadiosActvAdf14DigOnesDown { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_ones_down", "4-digit ADF active 1 ones down."); } }
        public static XPlaneCommand RadiosActvAdf14DigOnesUp { get { return new XPlaneCommand("sim/radios/actv_adf1_4dig_ones_up", "4-digit ADF active 1 ones up."); } }
        public static XPlaneCommand RadiosStbyAdf1HundredsDown { get { return new XPlaneCommand("sim/radios/stby_adf1_hundreds_down", "ADF standby 1 hundreds down."); } }
        public static XPlaneCommand RadiosStbyAdf1HundredsUp { get { return new XPlaneCommand("sim/radios/stby_adf1_hundreds_up", "ADF standby 1 hundreds up."); } }
        public static XPlaneCommand RadiosStbyAdf1TensDown { get { return new XPlaneCommand("sim/radios/stby_adf1_tens_down", "ADF standby 1 tens down."); } }
        public static XPlaneCommand RadiosStbyAdf1TensUp { get { return new XPlaneCommand("sim/radios/stby_adf1_tens_up", "ADF standby 1 tens up."); } }
        public static XPlaneCommand RadiosStbyAdf1OnesDown { get { return new XPlaneCommand("sim/radios/stby_adf1_ones_down", "ADF standby 1 ones down."); } }
        public static XPlaneCommand RadiosStbyAdf1OnesUp { get { return new XPlaneCommand("sim/radios/stby_adf1_ones_up", "ADF standby 1 ones up."); } }
        public static XPlaneCommand RadiosStbyAdf1OnesTensDown { get { return new XPlaneCommand("sim/radios/stby_adf1_ones_tens_down", "ADF standby 1 ones and tens down."); } }
        public static XPlaneCommand RadiosStbyAdf1OnesTensUp { get { return new XPlaneCommand("sim/radios/stby_adf1_ones_tens_up", "ADF standby 1 ones and tens up."); } }
        public static XPlaneCommand RadiosStbyAdf1HundredsThousDown { get { return new XPlaneCommand("sim/radios/stby_adf1_hundreds_thous_down", "ADF standby 1 hundreds and thousands down."); } }
        public static XPlaneCommand RadiosStbyAdf1HundredsThousUp { get { return new XPlaneCommand("sim/radios/stby_adf1_hundreds_thous_up", "ADF standby 1 hundreds and thousands up."); } }
        public static XPlaneCommand RadiosStbyAdf14DigHundredsDown { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_hundreds_down", "4-digit ADF standby 1 hundreds down."); } }
        public static XPlaneCommand RadiosStbyAdf14DigHundredsUp { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_hundreds_up", "4-digit ADF standby 1 hundreds up."); } }
        public static XPlaneCommand RadiosStbyAdf14DigTensDown { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_tens_down", "4-digit ADF standby 1 tens down."); } }
        public static XPlaneCommand RadiosStbyAdf14DigTensUp { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_tens_up", "4-digit ADF standby 1 tens up."); } }
        public static XPlaneCommand RadiosStbyAdf14DigOnesDown { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_ones_down", "4-digit ADF standby 1 ones down."); } }
        public static XPlaneCommand RadiosStbyAdf14DigOnesUp { get { return new XPlaneCommand("sim/radios/stby_adf1_4dig_ones_up", "4-digit ADF standby 1 ones up."); } }
        public static XPlaneCommand RadiosActvAdf2HundredsDown { get { return new XPlaneCommand("sim/radios/actv_adf2_hundreds_down", "ADF active 2 hundreds down."); } }
        public static XPlaneCommand RadiosActvAdf2HundredsUp { get { return new XPlaneCommand("sim/radios/actv_adf2_hundreds_up", "ADF active 2 hundreds up."); } }
        public static XPlaneCommand RadiosActvAdf2TensDown { get { return new XPlaneCommand("sim/radios/actv_adf2_tens_down", "ADF active 2 tens down."); } }
        public static XPlaneCommand RadiosActvAdf2TensUp { get { return new XPlaneCommand("sim/radios/actv_adf2_tens_up", "ADF active 2 tens up."); } }
        public static XPlaneCommand RadiosActvAdf2OnesDown { get { return new XPlaneCommand("sim/radios/actv_adf2_ones_down", "ADF active 2 ones down."); } }
        public static XPlaneCommand RadiosActvAdf2OnesUp { get { return new XPlaneCommand("sim/radios/actv_adf2_ones_up", "ADF active 2 ones up."); } }
        public static XPlaneCommand RadiosActvAdf2OnesTensDown { get { return new XPlaneCommand("sim/radios/actv_adf2_ones_tens_down", "ADF active 2 ones and tens down."); } }
        public static XPlaneCommand RadiosActvAdf2OnesTensUp { get { return new XPlaneCommand("sim/radios/actv_adf2_ones_tens_up", "ADF active 2 ones and tens up."); } }
        public static XPlaneCommand RadiosActvAdf2HundredsThousDown { get { return new XPlaneCommand("sim/radios/actv_adf2_hundreds_thous_down", "ADF active 2 hundreds and thousands down."); } }
        public static XPlaneCommand RadiosActvAdf2HundredsThousUp { get { return new XPlaneCommand("sim/radios/actv_adf2_hundreds_thous_up", "ADF active 2 hundreds and thousands up."); } }
        public static XPlaneCommand RadiosActvAdf24DigHundredsDown { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_hundreds_down", "4-digit ADF active 2 hundreds down."); } }
        public static XPlaneCommand RadiosActvAdf24DigHundredsUp { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_hundreds_up", "4-digit ADF active 2 hundreds up."); } }
        public static XPlaneCommand RadiosActvAdf24DigTensDown { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_tens_down", "4-digit ADF active 2 tens down."); } }
        public static XPlaneCommand RadiosActvAdf24DigTensUp { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_tens_up", "4-digit ADF active 2 tens up."); } }
        public static XPlaneCommand RadiosActvAdf24DigOnesDown { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_ones_down", "4-digit ADF active 2 ones down."); } }
        public static XPlaneCommand RadiosActvAdf24DigOnesUp { get { return new XPlaneCommand("sim/radios/actv_adf2_4dig_ones_up", "4-digit ADF active 2 ones up."); } }
        public static XPlaneCommand RadiosStbyAdf2HundredsDown { get { return new XPlaneCommand("sim/radios/stby_adf2_hundreds_down", "ADF standby 2 hundreds down."); } }
        public static XPlaneCommand RadiosStbyAdf2HundredsUp { get { return new XPlaneCommand("sim/radios/stby_adf2_hundreds_up", "ADF standby 2 hundreds up."); } }
        public static XPlaneCommand RadiosStbyAdf2TensDown { get { return new XPlaneCommand("sim/radios/stby_adf2_tens_down", "ADF standby 2 tens down."); } }
        public static XPlaneCommand RadiosStbyAdf2TensUp { get { return new XPlaneCommand("sim/radios/stby_adf2_tens_up", "ADF standby 2 tens up."); } }
        public static XPlaneCommand RadiosStbyAdf2OnesDown { get { return new XPlaneCommand("sim/radios/stby_adf2_ones_down", "ADF standby 2 ones down."); } }
        public static XPlaneCommand RadiosStbyAdf2OnesUp { get { return new XPlaneCommand("sim/radios/stby_adf2_ones_up", "ADF standby 2 ones up."); } }
        public static XPlaneCommand RadiosStbyAdf2OnesTensDown { get { return new XPlaneCommand("sim/radios/stby_adf2_ones_tens_down", "ADF standby 2 ones and tens down."); } }
        public static XPlaneCommand RadiosStbyAdf2OnesTensUp { get { return new XPlaneCommand("sim/radios/stby_adf2_ones_tens_up", "ADF standby 2 ones and tens up."); } }
        public static XPlaneCommand RadiosStbyAdf2HundredsThousDown { get { return new XPlaneCommand("sim/radios/stby_adf2_hundreds_thous_down", "ADF standby 2 hundreds and thousands down."); } }
        public static XPlaneCommand RadiosStbyAdf2HundredsThousUp { get { return new XPlaneCommand("sim/radios/stby_adf2_hundreds_thous_up", "ADF standby 2 hundreds and thousands up."); } }
        public static XPlaneCommand RadiosStbyAdf24DigHundredsDown { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_hundreds_down", "4-digit ADF standby 2 hundreds down."); } }
        public static XPlaneCommand RadiosStbyAdf24DigHundredsUp { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_hundreds_up", "4-digit ADF standby 2 hundreds up."); } }
        public static XPlaneCommand RadiosStbyAdf24DigTensDown { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_tens_down", "4-digit ADF standby 2 tens down."); } }
        public static XPlaneCommand RadiosStbyAdf24DigTensUp { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_tens_up", "4-digit ADF standby 2 tens up."); } }
        public static XPlaneCommand RadiosStbyAdf24DigOnesDown { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_ones_down", "4-digit ADF standby 2 ones down."); } }
        public static XPlaneCommand RadiosStbyAdf24DigOnesUp { get { return new XPlaneCommand("sim/radios/stby_adf2_4dig_ones_up", "4-digit ADF standby 2 ones up."); } }
        public static XPlaneCommand TransponderTransponderDigit0 { get { return new XPlaneCommand("sim/transponder/transponder_digit_0", "Transponder digit to 0."); } }
        public static XPlaneCommand TransponderTransponderDigit1 { get { return new XPlaneCommand("sim/transponder/transponder_digit_1", "Transponder digit to 1."); } }
        public static XPlaneCommand TransponderTransponderDigit2 { get { return new XPlaneCommand("sim/transponder/transponder_digit_2", "Transponder digit to 2."); } }
        public static XPlaneCommand TransponderTransponderDigit3 { get { return new XPlaneCommand("sim/transponder/transponder_digit_3", "Transponder digit to 3."); } }
        public static XPlaneCommand TransponderTransponderDigit4 { get { return new XPlaneCommand("sim/transponder/transponder_digit_4", "Transponder digit to 4."); } }
        public static XPlaneCommand TransponderTransponderDigit5 { get { return new XPlaneCommand("sim/transponder/transponder_digit_5", "Transponder digit to 5."); } }
        public static XPlaneCommand TransponderTransponderDigit6 { get { return new XPlaneCommand("sim/transponder/transponder_digit_6", "Transponder digit to 6."); } }
        public static XPlaneCommand TransponderTransponderDigit7 { get { return new XPlaneCommand("sim/transponder/transponder_digit_7", "Transponder digit to 7."); } }
        public static XPlaneCommand TransponderTransponderCLR { get { return new XPlaneCommand("sim/transponder/transponder_CLR", "Transponder reset to first digit."); } }
        public static XPlaneCommand TransponderTransponderThousandsDown { get { return new XPlaneCommand("sim/transponder/transponder_thousands_down", "Transponder thousands down."); } }
        public static XPlaneCommand TransponderTransponderThousandsUp { get { return new XPlaneCommand("sim/transponder/transponder_thousands_up", "Transponder thousands up."); } }
        public static XPlaneCommand TransponderTransponderHundredsDown { get { return new XPlaneCommand("sim/transponder/transponder_hundreds_down", "Transponder hundreds down."); } }
        public static XPlaneCommand TransponderTransponderHundredsUp { get { return new XPlaneCommand("sim/transponder/transponder_hundreds_up", "Transponder hundreds up."); } }
        public static XPlaneCommand TransponderTransponderTensDown { get { return new XPlaneCommand("sim/transponder/transponder_tens_down", "Transponder tens down."); } }
        public static XPlaneCommand TransponderTransponderTensUp { get { return new XPlaneCommand("sim/transponder/transponder_tens_up", "Transponder tens up."); } }
        public static XPlaneCommand TransponderTransponderOnesDown { get { return new XPlaneCommand("sim/transponder/transponder_ones_down", "Transponder ones down."); } }
        public static XPlaneCommand TransponderTransponderOnesUp { get { return new XPlaneCommand("sim/transponder/transponder_ones_up", "Transponder ones up."); } }
        public static XPlaneCommand TransponderTransponder12Down { get { return new XPlaneCommand("sim/transponder/transponder_12_down", "Transponder digits 1 and 2 down."); } }
        public static XPlaneCommand TransponderTransponder12Up { get { return new XPlaneCommand("sim/transponder/transponder_12_up", "Transponder digits 1 and 2 up."); } }
        public static XPlaneCommand TransponderTransponder34Down { get { return new XPlaneCommand("sim/transponder/transponder_34_down", "Transponder digits 3 and 4 down."); } }
        public static XPlaneCommand TransponderTransponder34Up { get { return new XPlaneCommand("sim/transponder/transponder_34_up", "Transponder digits 3 and 4 up."); } }
        public static XPlaneCommand AudioPanelTransmitAudioCom1 { get { return new XPlaneCommand("sim/audio_panel/transmit_audio_com1", "Transmit audio: COM1."); } }
        public static XPlaneCommand AudioPanelTransmitAudioCom2 { get { return new XPlaneCommand("sim/audio_panel/transmit_audio_com2", "Transmit audio: COM2."); } }
        public static XPlaneCommand AudioPanelMonitorAudioComAuto { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com_auto", "Monitor audio: COM auto (same as transmit) toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom1 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com1", "Monitor audio: COM1 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom2 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com2", "Monitor audio: COM2 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav1 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav1", "Monitor audio: NAV1 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav2 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav2", "Monitor audio: NAV2 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf1 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf1", "Monitor audio: ADF1 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf2 { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf2", "Monitor audio: ADF2 toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioDme { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_dme", "Monitor audio: DME toggle."); } }
        public static XPlaneCommand AudioPanelMonitorAudioMkr { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_mkr", "Monitor audio: MKR toggle."); } }
        public static XPlaneCommand AudioPanelTransmitAudioCom1Man { get { return new XPlaneCommand("sim/audio_panel/transmit_audio_com1_man", "Transmit audio: COM1 - old panel, doesn't change listener."); } }
        public static XPlaneCommand AudioPanelTransmitAudioCom2Man { get { return new XPlaneCommand("sim/audio_panel/transmit_audio_com2_man", "Transmit audio: COM2 - old panel, doesn't change listener."); } }
        public static XPlaneCommand AudioPanelMonitorAudioComAutoOff { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com_auto_off", "Monitor audio: COM auto (same as transmit) off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom1Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com1_off", "Monitor audio: COM1 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom2Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com2_off", "Monitor audio: COM2 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav1Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav1_off", "Monitor audio: NAV1 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav2Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav2_off", "Monitor audio: NAV2 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf1Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf1_off", "Monitor audio: ADF1 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf2Off { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf2_off", "Monitor audio: ADF2 off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioDmeOff { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_dme_off", "Monitor audio: DME off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioMkrOff { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_mkr_off", "Monitor audio: MKR off."); } }
        public static XPlaneCommand AudioPanelMonitorAudioComAutoOn { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com_auto_on", "Monitor audio: COM auto (same as transmit) on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom1On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com1_on", "Monitor audio: COM1 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioCom2On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_com2_on", "Monitor audio: COM2 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav1On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav1_on", "Monitor audio: NAV1 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioNav2On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_nav2_on", "Monitor audio: NAV2 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf1On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf1_on", "Monitor audio: ADF1 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioAdf2On { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_adf2_on", "Monitor audio: ADF2 on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioDmeOn { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_dme_on", "Monitor audio: DME on."); } }
        public static XPlaneCommand AudioPanelMonitorAudioMkrOn { get { return new XPlaneCommand("sim/audio_panel/monitor_audio_mkr_on", "Monitor audio: MKR on."); } }
        public static XPlaneCommand TransponderTransponderIdent { get { return new XPlaneCommand("sim/transponder/transponder_ident", "Transponder ID."); } }
        public static XPlaneCommand TransponderTransponderOff { get { return new XPlaneCommand("sim/transponder/transponder_off", "Transponder off."); } }
        public static XPlaneCommand TransponderTransponderStandby { get { return new XPlaneCommand("sim/transponder/transponder_standby", "Transponder standby."); } }
        public static XPlaneCommand TransponderTransponderOn { get { return new XPlaneCommand("sim/transponder/transponder_on", "Transponder on."); } }
        public static XPlaneCommand TransponderTransponderAlt { get { return new XPlaneCommand("sim/transponder/transponder_alt", "Transponder alt."); } }
        public static XPlaneCommand TransponderTransponderTest { get { return new XPlaneCommand("sim/transponder/transponder_test", "Transponder test."); } }
        public static XPlaneCommand TransponderTransponderGround { get { return new XPlaneCommand("sim/transponder/transponder_ground", "Transponder ground."); } }
        public static XPlaneCommand TransponderTransponderDn { get { return new XPlaneCommand("sim/transponder/transponder_dn", "Transponder mode down."); } }
        public static XPlaneCommand TransponderTransponderUp { get { return new XPlaneCommand("sim/transponder/transponder_up", "Transponder mode up."); } }
        public static XPlaneCommand RadiosNav1StandyFlip { get { return new XPlaneCommand("sim/radios/nav1_standy_flip", "NAV 1 flip standby."); } }
        public static XPlaneCommand RadiosNav2StandyFlip { get { return new XPlaneCommand("sim/radios/nav2_standy_flip", "NAV 2 flip standby."); } }
        public static XPlaneCommand RadiosCom1StandyFlip { get { return new XPlaneCommand("sim/radios/com1_standy_flip", "COM 1 flip standby."); } }
        public static XPlaneCommand RadiosCom2StandyFlip { get { return new XPlaneCommand("sim/radios/com2_standy_flip", "COM 2 flip standby."); } }
        public static XPlaneCommand RadiosAdf1StandyFlip { get { return new XPlaneCommand("sim/radios/adf1_standy_flip", "ADF 1 flip standby."); } }
        public static XPlaneCommand RadiosAdf2StandyFlip { get { return new XPlaneCommand("sim/radios/adf2_standy_flip", "ADF 2 flip standby."); } }
        public static XPlaneCommand RadiosDmeStandbyFlip { get { return new XPlaneCommand("sim/radios/dme_standby_flip", "DME flip standby."); } }
        public static XPlaneCommand RadiosRMILTog { get { return new XPlaneCommand("sim/radios/RMI_L_tog", "RMI left NAV toggle VOR/NDB."); } }
        public static XPlaneCommand RadiosRMIRTog { get { return new XPlaneCommand("sim/radios/RMI_R_tog", "RMI right NAV toggle VOR/NDB."); } }
        public static XPlaneCommand RadiosCopilotRMILTogCop { get { return new XPlaneCommand("sim/radios/copilot_RMI_L_tog_cop", "Copilot RMI left NAV toggle VOR/NDB."); } }
        public static XPlaneCommand RadiosCopilotRMIRTogCop { get { return new XPlaneCommand("sim/radios/copilot_RMI_R_tog_cop", "Copilot RMI right NAV toggle VOR/NDB."); } }
        public static XPlaneCommand InstrumentsECAMModeUp { get { return new XPlaneCommand("sim/instruments/ECAM_mode_up", "ECAM mode up."); } }
        public static XPlaneCommand InstrumentsECAMModeDown { get { return new XPlaneCommand("sim/instruments/ECAM_mode_down", "ECAM mode down."); } }
        public static XPlaneCommand InstrumentsMapZoomIn { get { return new XPlaneCommand("sim/instruments/map_zoom_in", "Zoom in EFIS map."); } }
        public static XPlaneCommand InstrumentsMapZoomOut { get { return new XPlaneCommand("sim/instruments/map_zoom_out", "Zoom out EFIS map."); } }
        public static XPlaneCommand InstrumentsEFISWxr { get { return new XPlaneCommand("sim/instruments/EFIS_wxr", "EFIS map weather."); } }
        public static XPlaneCommand InstrumentsEFISTcas { get { return new XPlaneCommand("sim/instruments/EFIS_tcas", "EFIS map TCAS."); } }
        public static XPlaneCommand InstrumentsEFISApt { get { return new XPlaneCommand("sim/instruments/EFIS_apt", "EFIS map airport."); } }
        public static XPlaneCommand InstrumentsEFISFix { get { return new XPlaneCommand("sim/instruments/EFIS_fix", "EFIS map fix."); } }
        public static XPlaneCommand InstrumentsEFISVor { get { return new XPlaneCommand("sim/instruments/EFIS_vor", "EFIS map VOR."); } }
        public static XPlaneCommand InstrumentsEFISNdb { get { return new XPlaneCommand("sim/instruments/EFIS_ndb", "EFIS map NDB."); } }
        public static XPlaneCommand InstrumentsEFISPageUp { get { return new XPlaneCommand("sim/instruments/EFIS_page_up", "EFIS page up."); } }
        public static XPlaneCommand InstrumentsEFISPageDn { get { return new XPlaneCommand("sim/instruments/EFIS_page_dn", "EFIS page down."); } }
        public static XPlaneCommand InstrumentsEFISModeUp { get { return new XPlaneCommand("sim/instruments/EFIS_mode_up", "EFIS mode up (APP/VOR/MAP/PLN)"); } }
        public static XPlaneCommand InstrumentsEFISModeDn { get { return new XPlaneCommand("sim/instruments/EFIS_mode_dn", "EFIS mode down (PLN/MAP/VOR/APP)"); } }
        public static XPlaneCommand InstrumentsEFIS1PilotSelDn { get { return new XPlaneCommand("sim/instruments/EFIS_1_pilot_sel_dn", "EFIS 1 selection pilot down (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS1PilotSelUp { get { return new XPlaneCommand("sim/instruments/EFIS_1_pilot_sel_up", "EFIS 1 selection pilot up (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS1CopilotSelDn { get { return new XPlaneCommand("sim/instruments/EFIS_1_copilot_sel_dn", "EFIS 1 selection copilot down (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS1CopilotSelUp { get { return new XPlaneCommand("sim/instruments/EFIS_1_copilot_sel_up", "EFIS 1 selection copilot up (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS2PilotSelDn { get { return new XPlaneCommand("sim/instruments/EFIS_2_pilot_sel_dn", "EFIS 2 selection pilot down (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS2PilotSelUp { get { return new XPlaneCommand("sim/instruments/EFIS_2_pilot_sel_up", "EFIS 2 selection pilot up (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS2CopilotSelDn { get { return new XPlaneCommand("sim/instruments/EFIS_2_copilot_sel_dn", "EFIS 2 selection copilot down (ADF/off/VOR)"); } }
        public static XPlaneCommand InstrumentsEFIS2CopilotSelUp { get { return new XPlaneCommand("sim/instruments/EFIS_2_copilot_sel_up", "EFIS 2 selection copilot up (ADF/off/VOR)"); } }
        public static XPlaneCommand RadiosObs1Down { get { return new XPlaneCommand("sim/radios/obs1_down", "OBS 1 down."); } }
        public static XPlaneCommand RadiosObs1Up { get { return new XPlaneCommand("sim/radios/obs1_up", "OBS 1 up."); } }
        public static XPlaneCommand RadiosObs2Down { get { return new XPlaneCommand("sim/radios/obs2_down", "OBS 2 down."); } }
        public static XPlaneCommand RadiosObs2Up { get { return new XPlaneCommand("sim/radios/obs2_up", "OBS 2 up."); } }
        public static XPlaneCommand RadiosObsHSIDown { get { return new XPlaneCommand("sim/radios/obs_HSI_down", "OBS HSI down."); } }
        public static XPlaneCommand RadiosObsHSIUp { get { return new XPlaneCommand("sim/radios/obs_HSI_up", "OBS HSI up."); } }
        public static XPlaneCommand RadiosObsHSIDirect { get { return new XPlaneCommand("sim/radios/obs_HSI_direct", "OBS HSI direct course."); } }
        public static XPlaneCommand RadiosAdf1CardDown { get { return new XPlaneCommand("sim/radios/adf1_card_down", "ADF card 1 down."); } }
        public static XPlaneCommand RadiosAdf1CardUp { get { return new XPlaneCommand("sim/radios/adf1_card_up", "ADF card 1 up."); } }
        public static XPlaneCommand RadiosAdf2CardDown { get { return new XPlaneCommand("sim/radios/adf2_card_down", "ADF card 2 down."); } }
        public static XPlaneCommand RadiosAdf2CardUp { get { return new XPlaneCommand("sim/radios/adf2_card_up", "ADF card 2 up."); } }
        public static XPlaneCommand RadiosCopilotObs1Down { get { return new XPlaneCommand("sim/radios/copilot_obs1_down", "Copilot OBS 1 down."); } }
        public static XPlaneCommand RadiosCopilotObs1Up { get { return new XPlaneCommand("sim/radios/copilot_obs1_up", "Copilot OBS 1 up."); } }
        public static XPlaneCommand RadiosCopilotObs2Down { get { return new XPlaneCommand("sim/radios/copilot_obs2_down", "Copilot OBS 2 down."); } }
        public static XPlaneCommand RadiosCopilotObs2Up { get { return new XPlaneCommand("sim/radios/copilot_obs2_up", "Copilot OBS 2 up."); } }
        public static XPlaneCommand RadiosCopilotObsHSIDown { get { return new XPlaneCommand("sim/radios/copilot_obs_HSI_down", "Copilot OBS HSI down."); } }
        public static XPlaneCommand RadiosCopilotObsHSIUp { get { return new XPlaneCommand("sim/radios/copilot_obs_HSI_up", "Copilot OBS HSI up."); } }
        public static XPlaneCommand RadiosCopilotObsHSIDirect { get { return new XPlaneCommand("sim/radios/copilot_obs_HSI_direct", "Copilot OBS HSI direct course."); } }
        public static XPlaneCommand RadiosCopilotAdf1CardDown { get { return new XPlaneCommand("sim/radios/copilot_adf1_card_down", "Copilot ADF card 1 down."); } }
        public static XPlaneCommand RadiosCopilotAdf1CardUp { get { return new XPlaneCommand("sim/radios/copilot_adf1_card_up", "Copilot ADF card 1 up."); } }
        public static XPlaneCommand RadiosCopilotAdf2CardDown { get { return new XPlaneCommand("sim/radios/copilot_adf2_card_down", "Copilot ADF card 2 down."); } }
        public static XPlaneCommand RadiosCopilotAdf2CardUp { get { return new XPlaneCommand("sim/radios/copilot_adf2_card_up", "Copilot ADF card 2 up."); } }
        public static XPlaneCommand AutopilotHsiSelectDown { get { return new XPlaneCommand("sim/autopilot/hsi_select_down", "HSI select down one."); } }
        public static XPlaneCommand AutopilotHsiSelectUp { get { return new XPlaneCommand("sim/autopilot/hsi_select_up", "HSI select up one."); } }
        public static XPlaneCommand AutopilotHsiSelectNav1 { get { return new XPlaneCommand("sim/autopilot/hsi_select_nav_1", "HSI shows NAV 1."); } }
        public static XPlaneCommand AutopilotHsiSelectNav2 { get { return new XPlaneCommand("sim/autopilot/hsi_select_nav_2", "HSI shows NAV 2."); } }
        public static XPlaneCommand AutopilotHsiSelectGps { get { return new XPlaneCommand("sim/autopilot/hsi_select_gps", "HSI shows GPS."); } }
        public static XPlaneCommand AutopilotHsiSelectCopilotDown { get { return new XPlaneCommand("sim/autopilot/hsi_select_copilot_down", "HSI select down one, copilot."); } }
        public static XPlaneCommand AutopilotHsiSelectCopilotUp { get { return new XPlaneCommand("sim/autopilot/hsi_select_copilot_up", "HSI select up one, copilot."); } }
        public static XPlaneCommand AutopilotHsiSelectCopilotNav1 { get { return new XPlaneCommand("sim/autopilot/hsi_select_copilot_nav_1", "HSI shows NAV 1, copilot."); } }
        public static XPlaneCommand AutopilotHsiSelectCopilotNav2 { get { return new XPlaneCommand("sim/autopilot/hsi_select_copilot_nav_2", "HSI shows NAV 2, copilot."); } }
        public static XPlaneCommand AutopilotHsiSelectCopilotGps { get { return new XPlaneCommand("sim/autopilot/hsi_select_copilot_gps", "HSI shows GPS, copilot."); } }
        public static XPlaneCommand FlightControlsCarrierILS { get { return new XPlaneCommand("sim/flight_controls/carrier_ILS", "Set the radios for the carrier ILS."); } }
        public static XPlaneCommand AutopilotSource01 { get { return new XPlaneCommand("sim/autopilot/source_01", "Change autopilot instrument source, 0 or 1"); } }
        public static XPlaneCommand AutopilotFdirOn { get { return new XPlaneCommand("sim/autopilot/fdir_on", "Flight director on."); } }
        public static XPlaneCommand AutopilotFdirToggle { get { return new XPlaneCommand("sim/autopilot/fdir_toggle", "Flight director toggle."); } }
        public static XPlaneCommand AutopilotServosOn { get { return new XPlaneCommand("sim/autopilot/servos_on", "Servos on."); } }
        public static XPlaneCommand AutopilotServosToggle { get { return new XPlaneCommand("sim/autopilot/servos_toggle", "Servos toggle."); } }
        public static XPlaneCommand AutopilotFdirServosDownOne { get { return new XPlaneCommand("sim/autopilot/fdir_servos_down_one", "Flight director down (on/FDIR/off)."); } }
        public static XPlaneCommand AutopilotFdirServosUpOne { get { return new XPlaneCommand("sim/autopilot/fdir_servos_up_one", "Flight director up (off/FDIR/on)."); } }
        public static XPlaneCommand AutopilotServosFdirOff { get { return new XPlaneCommand("sim/autopilot/servos_fdir_off", "Disco servos, flt dir."); } }
        public static XPlaneCommand AutopilotServosFdirYawdOff { get { return new XPlaneCommand("sim/autopilot/servos_fdir_yawd_off", "Disco servos, flt dir, yaw damp."); } }
        public static XPlaneCommand AutopilotServosFdirYawdTrimOff { get { return new XPlaneCommand("sim/autopilot/servos_fdir_yawd_trim_off", "Disco servos, flt dir, yaw damp, trim."); } }
        public static XPlaneCommand AutopilotControlWheelSteer { get { return new XPlaneCommand("sim/autopilot/control_wheel_steer", "Control wheel steering mode."); } }
        public static XPlaneCommand AutopilotFdir2On { get { return new XPlaneCommand("sim/autopilot/fdir2_on", "Flight director 2 on."); } }
        public static XPlaneCommand AutopilotFdir2Toggle { get { return new XPlaneCommand("sim/autopilot/fdir2_toggle", "Flight director 2 toggle."); } }
        public static XPlaneCommand AutopilotServos2On { get { return new XPlaneCommand("sim/autopilot/servos2_on", "Servos 2 on."); } }
        public static XPlaneCommand AutopilotServos2Toggle { get { return new XPlaneCommand("sim/autopilot/servos2_toggle", "Servos 2 toggle."); } }
        public static XPlaneCommand AutopilotFdir2ServosDownOne { get { return new XPlaneCommand("sim/autopilot/fdir2_servos_down_one", "Flight director 2 down (on/FDIR/off)."); } }
        public static XPlaneCommand AutopilotFdir2ServosUpOne { get { return new XPlaneCommand("sim/autopilot/fdir2_servos_up_one", "Flight director 2 up (off/FDIR/on)."); } }
        public static XPlaneCommand AutopilotServosFdir2Off { get { return new XPlaneCommand("sim/autopilot/servos_fdir2_off", "Disco servos 2, flt dir 2."); } }
        public static XPlaneCommand AutopilotCWSA { get { return new XPlaneCommand("sim/autopilot/CWSA", "CWS A - Control wheel steering mode AP A."); } }
        public static XPlaneCommand AutopilotCWSB { get { return new XPlaneCommand("sim/autopilot/CWSB", "CWS B - Control wheel steering mode AP B."); } }
        public static XPlaneCommand AutopilotServos3On { get { return new XPlaneCommand("sim/autopilot/servos3_on", "Servos 3 on."); } }
        public static XPlaneCommand AutopilotServos3Toggle { get { return new XPlaneCommand("sim/autopilot/servos3_toggle", "Servos 3 toggle."); } }
        public static XPlaneCommand AutopilotServosFdir3Off { get { return new XPlaneCommand("sim/autopilot/servos_fdir3_off", "Disco servos 3."); } }
        public static XPlaneCommand AutopilotServosOffAny { get { return new XPlaneCommand("sim/autopilot/servos_off_any", "Disco servos, which ever side is active."); } }
        public static XPlaneCommand AutopilotServosYawdOffAny { get { return new XPlaneCommand("sim/autopilot/servos_yawd_off_any", "Disco servos and yaw damp, any side."); } }
        public static XPlaneCommand AutopilotServosYawdTrimOffAny { get { return new XPlaneCommand("sim/autopilot/servos_yawd_trim_off_any", "Disco servos, yaw damp and trim any side."); } }
        public static XPlaneCommand AutopilotAutothrottleOn { get { return new XPlaneCommand("sim/autopilot/autothrottle_on", "Autopilot auto-throttle speed-hold on."); } }
        public static XPlaneCommand AutopilotAutothrottleOff { get { return new XPlaneCommand("sim/autopilot/autothrottle_off", "Autopilot auto-throttle all modes off."); } }
        public static XPlaneCommand AutopilotAutothrottleToggle { get { return new XPlaneCommand("sim/autopilot/autothrottle_toggle", "Autopilot auto-throttle speed toggle."); } }
        public static XPlaneCommand AutopilotAutothrottleN1epr { get { return new XPlaneCommand("sim/autopilot/autothrottle_n1epr", "Autopilot auto-throttle EPR/N1 hold on."); } }
        public static XPlaneCommand AutopilotAutothrottleN1eprToggle { get { return new XPlaneCommand("sim/autopilot/autothrottle_n1epr_toggle", "Autopilot auto-throttle EPR/N1 hold toggle."); } }
        public static XPlaneCommand AutopilotHeading { get { return new XPlaneCommand("sim/autopilot/heading", "Autopilot heading-select."); } }
        public static XPlaneCommand AutopilotTrack { get { return new XPlaneCommand("sim/autopilot/track", "Autopilot track."); } }
        public static XPlaneCommand AutopilotHeadingHold { get { return new XPlaneCommand("sim/autopilot/heading_hold", "Autopilot heading-hold."); } }
        public static XPlaneCommand AutopilotWingLeveler { get { return new XPlaneCommand("sim/autopilot/wing_leveler", "Autopilot wing-level / roll hold."); } }
        public static XPlaneCommand AutopilotRateHold { get { return new XPlaneCommand("sim/autopilot/rate_hold", "Autopilot wing-level / rate hold."); } }
        public static XPlaneCommand AutopilotHdgNav { get { return new XPlaneCommand("sim/autopilot/hdg_nav", "Autopilot heading select and NAV arm."); } }
        public static XPlaneCommand AutopilotNAV { get { return new XPlaneCommand("sim/autopilot/NAV", "Autopilot VOR/LOC arm."); } }
        public static XPlaneCommand AutopilotVerticalSpeed { get { return new XPlaneCommand("sim/autopilot/vertical_speed", "Autopilot vertical speed, at current VSI."); } }
        public static XPlaneCommand AutopilotFpa { get { return new XPlaneCommand("sim/autopilot/fpa", "Autopilot flight path angle, current FPA."); } }
        public static XPlaneCommand AutopilotAltVs { get { return new XPlaneCommand("sim/autopilot/alt_vs", "Autopilot vertical speed, at current VSI, arm ALT."); } }
        public static XPlaneCommand AutopilotVerticalSpeedPreSel { get { return new XPlaneCommand("sim/autopilot/vertical_speed_pre_sel", "Autopilot vertical speed, at pre-sel VSI."); } }
        public static XPlaneCommand AutopilotPitchSync { get { return new XPlaneCommand("sim/autopilot/pitch_sync", "Autopilot pitch-sync."); } }
        public static XPlaneCommand AutopilotLevelChange { get { return new XPlaneCommand("sim/autopilot/level_change", "Autopilot level change."); } }
        public static XPlaneCommand AutopilotAltitudeHold { get { return new XPlaneCommand("sim/autopilot/altitude_hold", "Autopilot altitude select or hold."); } }
        public static XPlaneCommand AutopilotTerrainFollowing { get { return new XPlaneCommand("sim/autopilot/terrain_following", "Autopilot terrain-mode following."); } }
        public static XPlaneCommand AutopilotTakeOffGoAround { get { return new XPlaneCommand("sim/autopilot/take_off_go_around", "Autopilot take-off go-around."); } }
        public static XPlaneCommand AutopilotReentry { get { return new XPlaneCommand("sim/autopilot/reentry", "Autopilot re-entry."); } }
        public static XPlaneCommand AutopilotGlideSlope { get { return new XPlaneCommand("sim/autopilot/glide_slope", "Autopilot glideslope."); } }
        public static XPlaneCommand AutopilotVnav { get { return new XPlaneCommand("sim/autopilot/vnav", "Autopilot VNAV for G1000."); } }
        public static XPlaneCommand AutopilotGpss { get { return new XPlaneCommand("sim/autopilot/gpss", "Autopilot GPS Steering."); } }
        public static XPlaneCommand AutopilotClimb { get { return new XPlaneCommand("sim/autopilot/climb", "Autopilot GPS Climb."); } }
        public static XPlaneCommand AutopilotDescend { get { return new XPlaneCommand("sim/autopilot/descend", "Autopilot GPS Descend."); } }
        public static XPlaneCommand AutopilotTrkfpa { get { return new XPlaneCommand("sim/autopilot/trkfpa", "Autopilot TRK/FPA vs HDG/VS toggle."); } }
        public static XPlaneCommand AutopilotAirspeedSync { get { return new XPlaneCommand("sim/autopilot/airspeed_sync", "Autopilot airspeed sync."); } }
        public static XPlaneCommand AutopilotHeadingSync { get { return new XPlaneCommand("sim/autopilot/heading_sync", "Autopilot heading sync."); } }
        public static XPlaneCommand AutopilotVerticalSpeedSync { get { return new XPlaneCommand("sim/autopilot/vertical_speed_sync", "Autopilot VVI sync."); } }
        public static XPlaneCommand AutopilotAltitudeSync { get { return new XPlaneCommand("sim/autopilot/altitude_sync", "Autopilot altitude sync."); } }
        public static XPlaneCommand AutopilotHeadingDown { get { return new XPlaneCommand("sim/autopilot/heading_down", "Autopilot heading down."); } }
        public static XPlaneCommand AutopilotHeadingUp { get { return new XPlaneCommand("sim/autopilot/heading_up", "Autopilot heading up."); } }
        public static XPlaneCommand AutopilotHeadingCopilotDown { get { return new XPlaneCommand("sim/autopilot/heading_copilot_down", "Autopilot heading copilot down."); } }
        public static XPlaneCommand AutopilotHeadingCopilotUp { get { return new XPlaneCommand("sim/autopilot/heading_copilot_up", "Autopilot heading copilot up."); } }
        public static XPlaneCommand AutopilotAirspeedDown { get { return new XPlaneCommand("sim/autopilot/airspeed_down", "Autopilot airspeed down."); } }
        public static XPlaneCommand AutopilotAirspeedUp { get { return new XPlaneCommand("sim/autopilot/airspeed_up", "Autopilot airspeed up."); } }
        public static XPlaneCommand AutopilotVerticalSpeedDown { get { return new XPlaneCommand("sim/autopilot/vertical_speed_down", "Autopilot VVI down."); } }
        public static XPlaneCommand AutopilotVerticalSpeedUp { get { return new XPlaneCommand("sim/autopilot/vertical_speed_up", "Autopilot VVI up."); } }
        public static XPlaneCommand AutopilotAltitudeDown { get { return new XPlaneCommand("sim/autopilot/altitude_down", "Autopilot altitude down."); } }
        public static XPlaneCommand AutopilotAltitudeUp { get { return new XPlaneCommand("sim/autopilot/altitude_up", "Autopilot altitude up."); } }
        public static XPlaneCommand AutopilotNoseDown { get { return new XPlaneCommand("sim/autopilot/nose_down", "Autopilot nose down."); } }
        public static XPlaneCommand AutopilotNoseUp { get { return new XPlaneCommand("sim/autopilot/nose_up", "Autopilot nose up."); } }
        public static XPlaneCommand AutopilotNoseDownPitchMode { get { return new XPlaneCommand("sim/autopilot/nose_down_pitch_mode", "Autopilot nose down, go into pitch mode."); } }
        public static XPlaneCommand AutopilotNoseUpPitchMode { get { return new XPlaneCommand("sim/autopilot/nose_up_pitch_mode", "Autopilot nose up, go into pitch mode"); } }
        public static XPlaneCommand AutopilotOverrideLeft { get { return new XPlaneCommand("sim/autopilot/override_left", "Autopilot override left: Go to ROL mode."); } }
        public static XPlaneCommand AutopilotOverrideRight { get { return new XPlaneCommand("sim/autopilot/override_right", "Autopilot override right: Go to ROL mode."); } }
        public static XPlaneCommand AutopilotOverrideCenter { get { return new XPlaneCommand("sim/autopilot/override_center", "Autopilot override center: Go to ROL mode, 0 turn rate roll angle."); } }
        public static XPlaneCommand AutopilotOverrideUp { get { return new XPlaneCommand("sim/autopilot/override_up", "Autopilot override up: Go to SYN mode."); } }
        public static XPlaneCommand AutopilotOverrideDown { get { return new XPlaneCommand("sim/autopilot/override_down", "Autopilot override down: Go to SYN mode."); } }
        public static XPlaneCommand AutopilotAltitudeArm { get { return new XPlaneCommand("sim/autopilot/altitude_arm", "Autopilot altitude hold ARM."); } }
        public static XPlaneCommand AutopilotApproach { get { return new XPlaneCommand("sim/autopilot/approach", "Autopilot approach."); } }
        public static XPlaneCommand AutopilotBackCourse { get { return new XPlaneCommand("sim/autopilot/back_course", "Autopilot back-course."); } }
        public static XPlaneCommand AutopilotKnotsMachToggle { get { return new XPlaneCommand("sim/autopilot/knots_mach_toggle", "Toggle knots-Mach airspeeed hold."); } }
        public static XPlaneCommand AutopilotFMS { get { return new XPlaneCommand("sim/autopilot/FMS", "Autopilot FMS altitude."); } }
        public static XPlaneCommand AutopilotBankLimitDown { get { return new XPlaneCommand("sim/autopilot/bank_limit_down", "Bank angle limit down."); } }
        public static XPlaneCommand AutopilotBankLimitUp { get { return new XPlaneCommand("sim/autopilot/bank_limit_up", "Bank angle limit up."); } }
        public static XPlaneCommand AutopilotBankLimitToggle { get { return new XPlaneCommand("sim/autopilot/bank_limit_toggle", "Bank angle limit toggle."); } }
        public static XPlaneCommand AutopilotSoftRideToggle { get { return new XPlaneCommand("sim/autopilot/soft_ride_toggle", "Soft ride toggle."); } }
        public static XPlaneCommand ElectricalDcVoltDn { get { return new XPlaneCommand("sim/electrical/dc_volt_dn", "DC Voltmeter down."); } }
        public static XPlaneCommand ElectricalDcVoltUp { get { return new XPlaneCommand("sim/electrical/dc_volt_up", "DC Voltmeter up."); } }
        public static XPlaneCommand ElectricalDcVoltExt { get { return new XPlaneCommand("sim/electrical/dc_volt_ext", "DC Voltmeter external power."); } }
        public static XPlaneCommand ElectricalDcVoltCtr { get { return new XPlaneCommand("sim/electrical/dc_volt_ctr", "DC Voltmeter center."); } }
        public static XPlaneCommand ElectricalDcVoltLft { get { return new XPlaneCommand("sim/electrical/dc_volt_lft", "DC Voltmeter left."); } }
        public static XPlaneCommand ElectricalDcVoltRgt { get { return new XPlaneCommand("sim/electrical/dc_volt_rgt", "DC Voltmeter right."); } }
        public static XPlaneCommand ElectricalDcVoltTpl { get { return new XPlaneCommand("sim/electrical/dc_volt_tpl", "DC Voltmeter TPL-fed."); } }
        public static XPlaneCommand ElectricalDcVoltBat { get { return new XPlaneCommand("sim/electrical/dc_volt_bat", "DC Voltmeter battery."); } }
        public static XPlaneCommand HUDPowerToggle { get { return new XPlaneCommand("sim/HUD/power_toggle", "HUD toggle power."); } }
        public static XPlaneCommand HUDBrightnessToggle { get { return new XPlaneCommand("sim/HUD/brightness_toggle", "HUD toggle brightness."); } }
        public static XPlaneCommand SystemsTotalEnergyAudioToggle { get { return new XPlaneCommand("sim/systems/total_energy_audio_toggle", "Toggle total-energy audio."); } }
        public static XPlaneCommand InstrumentsThermoUnitsToggle { get { return new XPlaneCommand("sim/instruments/thermo_units_toggle", "Toggle english/metric thermometer."); } }
        public static XPlaneCommand InstrumentsBarometer2992 { get { return new XPlaneCommand("sim/instruments/barometer_2992", "Baro pressure selection 2992."); } }
        public static XPlaneCommand InstrumentsDGSyncDown { get { return new XPlaneCommand("sim/instruments/DG_sync_down", "vacuum DG sync down."); } }
        public static XPlaneCommand InstrumentsDGSyncUp { get { return new XPlaneCommand("sim/instruments/DG_sync_up", "vacuum DG sync up."); } }
        public static XPlaneCommand InstrumentsDGSyncMag { get { return new XPlaneCommand("sim/instruments/DG_sync_mag", "vacuum DG sync to magnetic north."); } }
        public static XPlaneCommand InstrumentsCopilotDGSyncDown { get { return new XPlaneCommand("sim/instruments/copilot_DG_sync_down", "Copilot vacuum DG sync down."); } }
        public static XPlaneCommand InstrumentsCopilotDGSyncUp { get { return new XPlaneCommand("sim/instruments/copilot_DG_sync_up", "Copilot vacuum DG sync up."); } }
        public static XPlaneCommand InstrumentsCopilotDGSyncMag { get { return new XPlaneCommand("sim/instruments/copilot_DG_sync_mag", "Copilot vacuum DG sync to magnetic north."); } }
        public static XPlaneCommand InstrumentsFreeGyro { get { return new XPlaneCommand("sim/instruments/free_gyro", "electric DG free."); } }
        public static XPlaneCommand InstrumentsSlaveGyro { get { return new XPlaneCommand("sim/instruments/slave_gyro", "electric DG slave."); } }
        public static XPlaneCommand InstrumentsCopilotFreeGyro { get { return new XPlaneCommand("sim/instruments/copilot_free_gyro", "Copilot electric DG free."); } }
        public static XPlaneCommand InstrumentsCopilotSlaveGyro { get { return new XPlaneCommand("sim/instruments/copilot_slave_gyro", "Copilot electric DG slave."); } }
        public static XPlaneCommand InstrumentsFreeGyroDown { get { return new XPlaneCommand("sim/instruments/free_gyro_down", "electric DG free sync down."); } }
        public static XPlaneCommand InstrumentsFreeGyroUp { get { return new XPlaneCommand("sim/instruments/free_gyro_up", "electric DG free sync up."); } }
        public static XPlaneCommand InstrumentsCopilotFreeGyroDown { get { return new XPlaneCommand("sim/instruments/copilot_free_gyro_down", "Copilot electric DG free sync down."); } }
        public static XPlaneCommand InstrumentsCopilotFreeGyroUp { get { return new XPlaneCommand("sim/instruments/copilot_free_gyro_up", "Copilot electric DG free sync up."); } }
        public static XPlaneCommand InstrumentsAhRefDown { get { return new XPlaneCommand("sim/instruments/ah_ref_down", "Horizon reference down a bit."); } }
        public static XPlaneCommand InstrumentsAhRefUp { get { return new XPlaneCommand("sim/instruments/ah_ref_up", "Horizon reference up a bit."); } }
        public static XPlaneCommand InstrumentsAhRefCopilotDown { get { return new XPlaneCommand("sim/instruments/ah_ref_copilot_down", "Horizon reference down a bit, copilot."); } }
        public static XPlaneCommand InstrumentsAhRefCopilotUp { get { return new XPlaneCommand("sim/instruments/ah_ref_copilot_up", "Horizon reference down a bit, copilot."); } }
        public static XPlaneCommand InstrumentsAhFastErect { get { return new XPlaneCommand("sim/instruments/ah_fast_erect", "Attitude vacuum gyro fast erect."); } }
        public static XPlaneCommand InstrumentsAhCage { get { return new XPlaneCommand("sim/instruments/ah_cage", "Attitude vacuum gyro cage toggle."); } }
        public static XPlaneCommand InstrumentsAhFastErectCopilot { get { return new XPlaneCommand("sim/instruments/ah_fast_erect_copilot", "Attitude vacuum gyro fast erect, copilot."); } }
        public static XPlaneCommand InstrumentsAhCageCopilot { get { return new XPlaneCommand("sim/instruments/ah_cage_copilot", "Attitude vacuum gyro cage toggle, copilot"); } }
        public static XPlaneCommand InstrumentsBarometerDown { get { return new XPlaneCommand("sim/instruments/barometer_down", "Baro selection down a bit."); } }
        public static XPlaneCommand InstrumentsBarometerUp { get { return new XPlaneCommand("sim/instruments/barometer_up", "Baro selection up a bit."); } }
        public static XPlaneCommand InstrumentsBarometerCopilotDown { get { return new XPlaneCommand("sim/instruments/barometer_copilot_down", "Baro selection down a bit, copilot."); } }
        public static XPlaneCommand InstrumentsBarometerCopilotUp { get { return new XPlaneCommand("sim/instruments/barometer_copilot_up", "Baro selection up a bit, copilot."); } }
        public static XPlaneCommand InstrumentsBarometerStbyDown { get { return new XPlaneCommand("sim/instruments/barometer_stby_down", "Baro selection down a bit, standby alt."); } }
        public static XPlaneCommand InstrumentsBarometerStbyUp { get { return new XPlaneCommand("sim/instruments/barometer_stby_up", "Baro selection up a bit, standby alt."); } }
        public static XPlaneCommand InstrumentsBarometerApDown { get { return new XPlaneCommand("sim/instruments/barometer_ap_down", "Baro selection down a bit, AP presel."); } }
        public static XPlaneCommand InstrumentsBarometerApUp { get { return new XPlaneCommand("sim/instruments/barometer_ap_up", "Baro selection up a bit, AP presel."); } }
        public static XPlaneCommand InstrumentsDhRefDown { get { return new XPlaneCommand("sim/instruments/dh_ref_down", "Decision-height reference down."); } }
        public static XPlaneCommand InstrumentsDhRefUp { get { return new XPlaneCommand("sim/instruments/dh_ref_up", "Decision-height reference up."); } }
        public static XPlaneCommand InstrumentsDhRefCopilotDown { get { return new XPlaneCommand("sim/instruments/dh_ref_copilot_down", "Decision-height reference copilot down."); } }
        public static XPlaneCommand InstrumentsDhRefCopilotUp { get { return new XPlaneCommand("sim/instruments/dh_ref_copilot_up", "Decision-height reference copilot up."); } }
        public static XPlaneCommand InstrumentsMdaRefDown { get { return new XPlaneCommand("sim/instruments/mda_ref_down", "Minimum descend alt reference down."); } }
        public static XPlaneCommand InstrumentsMdaRefUp { get { return new XPlaneCommand("sim/instruments/mda_ref_up", "Minimum descend alt reference up."); } }
        public static XPlaneCommand InstrumentsMdaRefCopilotDown { get { return new XPlaneCommand("sim/instruments/mda_ref_copilot_down", "Minimum descend alt reference copilot down."); } }
        public static XPlaneCommand InstrumentsMdaRefCopilotUp { get { return new XPlaneCommand("sim/instruments/mda_ref_copilot_up", "Minimum descend alt reference copilot up."); } }
        public static XPlaneCommand InstrumentsBaroAltAlertCancel { get { return new XPlaneCommand("sim/instruments/baro_alt_alert_cancel", "Cancel altitude alert (preselector)."); } }
        public static XPlaneCommand InstrumentsMdaAlertCancel { get { return new XPlaneCommand("sim/instruments/mda_alert_cancel", "Cancel MDA alert."); } }
        public static XPlaneCommand InstrumentsPanelBrightDown { get { return new XPlaneCommand("sim/instruments/panel_bright_down", "Panel brightness down a bit."); } }
        public static XPlaneCommand InstrumentsPanelBrightUp { get { return new XPlaneCommand("sim/instruments/panel_bright_up", "Panel brightness up a bit."); } }
        public static XPlaneCommand InstrumentsInstrumentBrightDown { get { return new XPlaneCommand("sim/instruments/instrument_bright_down", "Instrument brightness down a bit."); } }
        public static XPlaneCommand InstrumentsInstrumentBrightUp { get { return new XPlaneCommand("sim/instruments/instrument_bright_up", "Instrument brightness up a bit."); } }
        public static XPlaneCommand AnnunciatorTestAllAnnunciators { get { return new XPlaneCommand("sim/annunciator/test_all_annunciators", "Test all annunciators."); } }
        public static XPlaneCommand AnnunciatorTestStall { get { return new XPlaneCommand("sim/annunciator/test_stall", "Test stall warn."); } }
        public static XPlaneCommand AnnunciatorTestFire1Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_1_annun", "Test fire 1 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire2Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_2_annun", "Test fire 2 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire3Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_3_annun", "Test fire 3 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire4Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_4_annun", "Test fire 4 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire5Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_5_annun", "Test fire 5 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire6Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_6_annun", "Test fire 6 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire7Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_7_annun", "Test fire 7 annunciator."); } }
        public static XPlaneCommand AnnunciatorTestFire8Annun { get { return new XPlaneCommand("sim/annunciator/test_fire_8_annun", "Test fire 8 annunciator."); } }
        public static XPlaneCommand AnnunciatorClearMasterCaution { get { return new XPlaneCommand("sim/annunciator/clear_master_caution", "Clear master caution."); } }
        public static XPlaneCommand AnnunciatorClearMasterWarning { get { return new XPlaneCommand("sim/annunciator/clear_master_warning", "Clear master warning."); } }
        public static XPlaneCommand AnnunciatorClearMasterAccept { get { return new XPlaneCommand("sim/annunciator/clear_master_accept", "Clear master accept."); } }
        public static XPlaneCommand FMSLs1L { get { return new XPlaneCommand("sim/FMS/ls_1l", "FMS: line select 1l"); } }
        public static XPlaneCommand FMSLs2L { get { return new XPlaneCommand("sim/FMS/ls_2l", "FMS: line select 2l"); } }
        public static XPlaneCommand FMSLs3L { get { return new XPlaneCommand("sim/FMS/ls_3l", "FMS: line select 3l"); } }
        public static XPlaneCommand FMSLs4L { get { return new XPlaneCommand("sim/FMS/ls_4l", "FMS: line select 4l"); } }
        public static XPlaneCommand FMSLs5L { get { return new XPlaneCommand("sim/FMS/ls_5l", "FMS: line select 5l"); } }
        public static XPlaneCommand FMSLs6L { get { return new XPlaneCommand("sim/FMS/ls_6l", "FMS: line select 6l"); } }
        public static XPlaneCommand FMSLs1R { get { return new XPlaneCommand("sim/FMS/ls_1r", "FMS: line select 1r"); } }
        public static XPlaneCommand FMSLs2R { get { return new XPlaneCommand("sim/FMS/ls_2r", "FMS: line select 2r"); } }
        public static XPlaneCommand FMSLs3R { get { return new XPlaneCommand("sim/FMS/ls_3r", "FMS: line select 3r"); } }
        public static XPlaneCommand FMSLs4R { get { return new XPlaneCommand("sim/FMS/ls_4r", "FMS: line select 4r"); } }
        public static XPlaneCommand FMSLs5R { get { return new XPlaneCommand("sim/FMS/ls_5r", "FMS: line select 5r"); } }
        public static XPlaneCommand FMSLs6R { get { return new XPlaneCommand("sim/FMS/ls_6r", "FMS: line select 6r"); } }
        public static XPlaneCommand FMSIndex { get { return new XPlaneCommand("sim/FMS/index", "FMS: INDEX"); } }
        public static XPlaneCommand FMSFpln { get { return new XPlaneCommand("sim/FMS/fpln", "FMS: FPLN"); } }
        public static XPlaneCommand FMSClb { get { return new XPlaneCommand("sim/FMS/clb", "FMS: CLB"); } }
        public static XPlaneCommand FMSCrz { get { return new XPlaneCommand("sim/FMS/crz", "FMS: CRZ"); } }
        public static XPlaneCommand FMSDes { get { return new XPlaneCommand("sim/FMS/des", "FMS: DES"); } }
        public static XPlaneCommand FMSDirIntc { get { return new XPlaneCommand("sim/FMS/dir_intc", "FMS: DIR/INTC"); } }
        public static XPlaneCommand FMSLegs { get { return new XPlaneCommand("sim/FMS/legs", "FMS: FPLN"); } }
        public static XPlaneCommand FMSDepArr { get { return new XPlaneCommand("sim/FMS/dep_arr", "FMS: DEP/ARR"); } }
        public static XPlaneCommand FMSHold { get { return new XPlaneCommand("sim/FMS/hold", "FMS: HOLD"); } }
        public static XPlaneCommand FMSProg { get { return new XPlaneCommand("sim/FMS/prog", "FMS: PROG"); } }
        public static XPlaneCommand FMSExec { get { return new XPlaneCommand("sim/FMS/exec", "FMS: EXEC"); } }
        public static XPlaneCommand FMSFix { get { return new XPlaneCommand("sim/FMS/fix", "FMS: FIX"); } }
        public static XPlaneCommand FMSNavrad { get { return new XPlaneCommand("sim/FMS/navrad", "FMS: NAVRAD"); } }
        public static XPlaneCommand FMSInit { get { return new XPlaneCommand("sim/FMS/init", "FMS: init"); } }
        public static XPlaneCommand FMSPrev { get { return new XPlaneCommand("sim/FMS/prev", "FMS: prev"); } }
        public static XPlaneCommand FMSNext { get { return new XPlaneCommand("sim/FMS/next", "FMS: next"); } }
        public static XPlaneCommand FMSClear { get { return new XPlaneCommand("sim/FMS/clear", "FMS: clear"); } }
        public static XPlaneCommand FMSDirect { get { return new XPlaneCommand("sim/FMS/direct", "FMS: direct"); } }
        public static XPlaneCommand FMSSign { get { return new XPlaneCommand("sim/FMS/sign", "FMS: sign"); } }
        public static XPlaneCommand FMSTypeApt { get { return new XPlaneCommand("sim/FMS/type_apt", "FMS: apt"); } }
        public static XPlaneCommand FMSTypeVor { get { return new XPlaneCommand("sim/FMS/type_vor", "FMS: vor"); } }
        public static XPlaneCommand FMSTypeNdb { get { return new XPlaneCommand("sim/FMS/type_ndb", "FMS: ndb"); } }
        public static XPlaneCommand FMSTypeFix { get { return new XPlaneCommand("sim/FMS/type_fix", "FMS: fix"); } }
        public static XPlaneCommand FMSTypeLatlon { get { return new XPlaneCommand("sim/FMS/type_latlon", "FMS: lat/lon"); } }
        public static XPlaneCommand FMSKey0 { get { return new XPlaneCommand("sim/FMS/key_0", "FMS: key_0"); } }
        public static XPlaneCommand FMSKey1 { get { return new XPlaneCommand("sim/FMS/key_1", "FMS: key_1"); } }
        public static XPlaneCommand FMSKey2 { get { return new XPlaneCommand("sim/FMS/key_2", "FMS: key_2"); } }
        public static XPlaneCommand FMSKey3 { get { return new XPlaneCommand("sim/FMS/key_3", "FMS: key_3"); } }
        public static XPlaneCommand FMSKey4 { get { return new XPlaneCommand("sim/FMS/key_4", "FMS: key_4"); } }
        public static XPlaneCommand FMSKey5 { get { return new XPlaneCommand("sim/FMS/key_5", "FMS: key_5"); } }
        public static XPlaneCommand FMSKey6 { get { return new XPlaneCommand("sim/FMS/key_6", "FMS: key_6"); } }
        public static XPlaneCommand FMSKey7 { get { return new XPlaneCommand("sim/FMS/key_7", "FMS: key_7"); } }
        public static XPlaneCommand FMSKey8 { get { return new XPlaneCommand("sim/FMS/key_8", "FMS: key_8"); } }
        public static XPlaneCommand FMSKey9 { get { return new XPlaneCommand("sim/FMS/key_9", "FMS: key_9"); } }
        public static XPlaneCommand FMSKeyA { get { return new XPlaneCommand("sim/FMS/key_A", "FMS: key_A"); } }
        public static XPlaneCommand FMSKeyB { get { return new XPlaneCommand("sim/FMS/key_B", "FMS: key_B"); } }
        public static XPlaneCommand FMSKeyC { get { return new XPlaneCommand("sim/FMS/key_C", "FMS: key_C"); } }
        public static XPlaneCommand FMSKeyD { get { return new XPlaneCommand("sim/FMS/key_D", "FMS: key_D"); } }
        public static XPlaneCommand FMSKeyE { get { return new XPlaneCommand("sim/FMS/key_E", "FMS: key_E"); } }
        public static XPlaneCommand FMSKeyF { get { return new XPlaneCommand("sim/FMS/key_F", "FMS: key_F"); } }
        public static XPlaneCommand FMSKeyG { get { return new XPlaneCommand("sim/FMS/key_G", "FMS: key_G"); } }
        public static XPlaneCommand FMSKeyH { get { return new XPlaneCommand("sim/FMS/key_H", "FMS: key_H"); } }
        public static XPlaneCommand FMSKeyI { get { return new XPlaneCommand("sim/FMS/key_I", "FMS: key_I"); } }
        public static XPlaneCommand FMSKeyJ { get { return new XPlaneCommand("sim/FMS/key_J", "FMS: key_J"); } }
        public static XPlaneCommand FMSKeyK { get { return new XPlaneCommand("sim/FMS/key_K", "FMS: key_K"); } }
        public static XPlaneCommand FMSKeyL { get { return new XPlaneCommand("sim/FMS/key_L", "FMS: key_L"); } }
        public static XPlaneCommand FMSKeyM { get { return new XPlaneCommand("sim/FMS/key_M", "FMS: key_M"); } }
        public static XPlaneCommand FMSKeyN { get { return new XPlaneCommand("sim/FMS/key_N", "FMS: key_N"); } }
        public static XPlaneCommand FMSKeyO { get { return new XPlaneCommand("sim/FMS/key_O", "FMS: key_O"); } }
        public static XPlaneCommand FMSKeyP { get { return new XPlaneCommand("sim/FMS/key_P", "FMS: key_P"); } }
        public static XPlaneCommand FMSKeyQ { get { return new XPlaneCommand("sim/FMS/key_Q", "FMS: key_Q"); } }
        public static XPlaneCommand FMSKeyR { get { return new XPlaneCommand("sim/FMS/key_R", "FMS: key_R"); } }
        public static XPlaneCommand FMSKeyS { get { return new XPlaneCommand("sim/FMS/key_S", "FMS: key_S"); } }
        public static XPlaneCommand FMSKeyT { get { return new XPlaneCommand("sim/FMS/key_T", "FMS: key_T"); } }
        public static XPlaneCommand FMSKeyU { get { return new XPlaneCommand("sim/FMS/key_U", "FMS: key_U"); } }
        public static XPlaneCommand FMSKeyV { get { return new XPlaneCommand("sim/FMS/key_V", "FMS: key_V"); } }
        public static XPlaneCommand FMSKeyW { get { return new XPlaneCommand("sim/FMS/key_W", "FMS: key_W"); } }
        public static XPlaneCommand FMSKeyX { get { return new XPlaneCommand("sim/FMS/key_X", "FMS: key_X"); } }
        public static XPlaneCommand FMSKeyY { get { return new XPlaneCommand("sim/FMS/key_Y", "FMS: key_Y"); } }
        public static XPlaneCommand FMSKeyZ { get { return new XPlaneCommand("sim/FMS/key_Z", "FMS: key_Z"); } }
        public static XPlaneCommand FMSKeyPeriod { get { return new XPlaneCommand("sim/FMS/key_period", "FMS: key_period"); } }
        public static XPlaneCommand FMSKeyMinus { get { return new XPlaneCommand("sim/FMS/key_minus", "FMS: key_minus"); } }
        public static XPlaneCommand FMSKeySlash { get { return new XPlaneCommand("sim/FMS/key_slash", "FMS: key_slash"); } }
        public static XPlaneCommand FMSKeyBack { get { return new XPlaneCommand("sim/FMS/key_back", "FMS: key_back"); } }
        public static XPlaneCommand FMSKeySpace { get { return new XPlaneCommand("sim/FMS/key_space", "FMS: key_space"); } }
        public static XPlaneCommand FMSKeyLoad { get { return new XPlaneCommand("sim/FMS/key_load", "FMS: key_load"); } }
        public static XPlaneCommand FMSKeySave { get { return new XPlaneCommand("sim/FMS/key_save", "FMS: key_save"); } }
        public static XPlaneCommand FMSKeyDelete { get { return new XPlaneCommand("sim/FMS/key_delete", "FMS: key_delete"); } }
        public static XPlaneCommand FMSKeyClear { get { return new XPlaneCommand("sim/FMS/key_clear", "FMS: key_clear"); } }
        public static XPlaneCommand FMSCDUPopup { get { return new XPlaneCommand("sim/FMS/CDU_popup", "FMS: CDU popup"); } }
        public static XPlaneCommand FMSCDUPopout { get { return new XPlaneCommand("sim/FMS/CDU_popout", "FMS: pop out CDU window"); } }
        public static XPlaneCommand FMSFixNext { get { return new XPlaneCommand("sim/FMS/fix_next", "FMS: next fix"); } }
        public static XPlaneCommand FMSFixPrev { get { return new XPlaneCommand("sim/FMS/fix_prev", "FMS: prev fix"); } }
        public static XPlaneCommand FMS2Ls1L { get { return new XPlaneCommand("sim/FMS2/ls_1l", "FMS2: line select 1l"); } }
        public static XPlaneCommand FMS2Ls2L { get { return new XPlaneCommand("sim/FMS2/ls_2l", "FMS2: line select 2l"); } }
        public static XPlaneCommand FMS2Ls3L { get { return new XPlaneCommand("sim/FMS2/ls_3l", "FMS2: line select 3l"); } }
        public static XPlaneCommand FMS2Ls4L { get { return new XPlaneCommand("sim/FMS2/ls_4l", "FMS2: line select 4l"); } }
        public static XPlaneCommand FMS2Ls5L { get { return new XPlaneCommand("sim/FMS2/ls_5l", "FMS2: line select 5l"); } }
        public static XPlaneCommand FMS2Ls6L { get { return new XPlaneCommand("sim/FMS2/ls_6l", "FMS2: line select 6l"); } }
        public static XPlaneCommand FMS2Ls1R { get { return new XPlaneCommand("sim/FMS2/ls_1r", "FMS2: line select 1r"); } }
        public static XPlaneCommand FMS2Ls2R { get { return new XPlaneCommand("sim/FMS2/ls_2r", "FMS2: line select 2r"); } }
        public static XPlaneCommand FMS2Ls3R { get { return new XPlaneCommand("sim/FMS2/ls_3r", "FMS2: line select 3r"); } }
        public static XPlaneCommand FMS2Ls4R { get { return new XPlaneCommand("sim/FMS2/ls_4r", "FMS2: line select 4r"); } }
        public static XPlaneCommand FMS2Ls5R { get { return new XPlaneCommand("sim/FMS2/ls_5r", "FMS2: line select 5r"); } }
        public static XPlaneCommand FMS2Ls6R { get { return new XPlaneCommand("sim/FMS2/ls_6r", "FMS2: line select 6r"); } }
        public static XPlaneCommand FMS2Index { get { return new XPlaneCommand("sim/FMS2/index", "FMS: INDEX"); } }
        public static XPlaneCommand FMS2Fpln { get { return new XPlaneCommand("sim/FMS2/fpln", "FMS2: FPLN"); } }
        public static XPlaneCommand FMS2Clb { get { return new XPlaneCommand("sim/FMS2/clb", "FMS2: CLB"); } }
        public static XPlaneCommand FMS2Crz { get { return new XPlaneCommand("sim/FMS2/crz", "FMS2: CRZ"); } }
        public static XPlaneCommand FMS2Des { get { return new XPlaneCommand("sim/FMS2/des", "FMS2: DES"); } }
        public static XPlaneCommand FMS2DirIntc { get { return new XPlaneCommand("sim/FMS2/dir_intc", "FMS2: DIR/INTC"); } }
        public static XPlaneCommand FMS2Legs { get { return new XPlaneCommand("sim/FMS2/legs", "FMS2: FPLN"); } }
        public static XPlaneCommand FMS2DepArr { get { return new XPlaneCommand("sim/FMS2/dep_arr", "FMS2: DEP/ARR"); } }
        public static XPlaneCommand FMS2Hold { get { return new XPlaneCommand("sim/FMS2/hold", "FMS2: HOLD"); } }
        public static XPlaneCommand FMS2Prog { get { return new XPlaneCommand("sim/FMS2/prog", "FMS2: PROG"); } }
        public static XPlaneCommand FMS2Exec { get { return new XPlaneCommand("sim/FMS2/exec", "FMS2: EXEC"); } }
        public static XPlaneCommand FMS2Fix { get { return new XPlaneCommand("sim/FMS2/fix", "FMS2: FIX"); } }
        public static XPlaneCommand FMS2Navrad { get { return new XPlaneCommand("sim/FMS2/navrad", "FMS2: NAVRAD"); } }
        public static XPlaneCommand FMS2Prev { get { return new XPlaneCommand("sim/FMS2/prev", "FMS2: prev"); } }
        public static XPlaneCommand FMS2Next { get { return new XPlaneCommand("sim/FMS2/next", "FMS2: next"); } }
        public static XPlaneCommand FMS2Key0 { get { return new XPlaneCommand("sim/FMS2/key_0", "FMS2: key_0"); } }
        public static XPlaneCommand FMS2Key1 { get { return new XPlaneCommand("sim/FMS2/key_1", "FMS2: key_1"); } }
        public static XPlaneCommand FMS2Key2 { get { return new XPlaneCommand("sim/FMS2/key_2", "FMS2: key_2"); } }
        public static XPlaneCommand FMS2Key3 { get { return new XPlaneCommand("sim/FMS2/key_3", "FMS2: key_3"); } }
        public static XPlaneCommand FMS2Key4 { get { return new XPlaneCommand("sim/FMS2/key_4", "FMS2: key_4"); } }
        public static XPlaneCommand FMS2Key5 { get { return new XPlaneCommand("sim/FMS2/key_5", "FMS2: key_5"); } }
        public static XPlaneCommand FMS2Key6 { get { return new XPlaneCommand("sim/FMS2/key_6", "FMS2: key_6"); } }
        public static XPlaneCommand FMS2Key7 { get { return new XPlaneCommand("sim/FMS2/key_7", "FMS2: key_7"); } }
        public static XPlaneCommand FMS2Key8 { get { return new XPlaneCommand("sim/FMS2/key_8", "FMS2: key_8"); } }
        public static XPlaneCommand FMS2Key9 { get { return new XPlaneCommand("sim/FMS2/key_9", "FMS2: key_9"); } }
        public static XPlaneCommand FMS2KeyA { get { return new XPlaneCommand("sim/FMS2/key_A", "FMS2: key_A"); } }
        public static XPlaneCommand FMS2KeyB { get { return new XPlaneCommand("sim/FMS2/key_B", "FMS2: key_B"); } }
        public static XPlaneCommand FMS2KeyC { get { return new XPlaneCommand("sim/FMS2/key_C", "FMS2: key_C"); } }
        public static XPlaneCommand FMS2KeyD { get { return new XPlaneCommand("sim/FMS2/key_D", "FMS2: key_D"); } }
        public static XPlaneCommand FMS2KeyE { get { return new XPlaneCommand("sim/FMS2/key_E", "FMS2: key_E"); } }
        public static XPlaneCommand FMS2KeyF { get { return new XPlaneCommand("sim/FMS2/key_F", "FMS2: key_F"); } }
        public static XPlaneCommand FMS2KeyG { get { return new XPlaneCommand("sim/FMS2/key_G", "FMS2: key_G"); } }
        public static XPlaneCommand FMS2KeyH { get { return new XPlaneCommand("sim/FMS2/key_H", "FMS2: key_H"); } }
        public static XPlaneCommand FMS2KeyI { get { return new XPlaneCommand("sim/FMS2/key_I", "FMS2: key_I"); } }
        public static XPlaneCommand FMS2KeyJ { get { return new XPlaneCommand("sim/FMS2/key_J", "FMS2: key_J"); } }
        public static XPlaneCommand FMS2KeyK { get { return new XPlaneCommand("sim/FMS2/key_K", "FMS2: key_K"); } }
        public static XPlaneCommand FMS2KeyL { get { return new XPlaneCommand("sim/FMS2/key_L", "FMS2: key_L"); } }
        public static XPlaneCommand FMS2KeyM { get { return new XPlaneCommand("sim/FMS2/key_M", "FMS2: key_M"); } }
        public static XPlaneCommand FMS2KeyN { get { return new XPlaneCommand("sim/FMS2/key_N", "FMS2: key_N"); } }
        public static XPlaneCommand FMS2KeyO { get { return new XPlaneCommand("sim/FMS2/key_O", "FMS2: key_O"); } }
        public static XPlaneCommand FMS2KeyP { get { return new XPlaneCommand("sim/FMS2/key_P", "FMS2: key_P"); } }
        public static XPlaneCommand FMS2KeyQ { get { return new XPlaneCommand("sim/FMS2/key_Q", "FMS2: key_Q"); } }
        public static XPlaneCommand FMS2KeyR { get { return new XPlaneCommand("sim/FMS2/key_R", "FMS2: key_R"); } }
        public static XPlaneCommand FMS2KeyS { get { return new XPlaneCommand("sim/FMS2/key_S", "FMS2: key_S"); } }
        public static XPlaneCommand FMS2KeyT { get { return new XPlaneCommand("sim/FMS2/key_T", "FMS2: key_T"); } }
        public static XPlaneCommand FMS2KeyU { get { return new XPlaneCommand("sim/FMS2/key_U", "FMS2: key_U"); } }
        public static XPlaneCommand FMS2KeyV { get { return new XPlaneCommand("sim/FMS2/key_V", "FMS2: key_V"); } }
        public static XPlaneCommand FMS2KeyW { get { return new XPlaneCommand("sim/FMS2/key_W", "FMS2: key_W"); } }
        public static XPlaneCommand FMS2KeyX { get { return new XPlaneCommand("sim/FMS2/key_X", "FMS2: key_X"); } }
        public static XPlaneCommand FMS2KeyY { get { return new XPlaneCommand("sim/FMS2/key_Y", "FMS2: key_Y"); } }
        public static XPlaneCommand FMS2KeyZ { get { return new XPlaneCommand("sim/FMS2/key_Z", "FMS2: key_Z"); } }
        public static XPlaneCommand FMS2KeyPeriod { get { return new XPlaneCommand("sim/FMS2/key_period", "FMS2: key_period"); } }
        public static XPlaneCommand FMS2KeyMinus { get { return new XPlaneCommand("sim/FMS2/key_minus", "FMS2: key_minus"); } }
        public static XPlaneCommand FMS2KeySlash { get { return new XPlaneCommand("sim/FMS2/key_slash", "FMS2: key_slash"); } }
        public static XPlaneCommand FMS2KeyBack { get { return new XPlaneCommand("sim/FMS2/key_back", "FMS2: key_back"); } }
        public static XPlaneCommand FMS2KeySpace { get { return new XPlaneCommand("sim/FMS2/key_space", "FMS2: key_space"); } }
        public static XPlaneCommand FMS2KeyDelete { get { return new XPlaneCommand("sim/FMS2/key_delete", "FMS2: key_delete"); } }
        public static XPlaneCommand FMS2KeyClear { get { return new XPlaneCommand("sim/FMS2/key_clear", "FMS2: key_clear"); } }
        public static XPlaneCommand FMS2CDUPopout { get { return new XPlaneCommand("sim/FMS2/CDU_popout", "FMS2: pop out CDU window"); } }
        public static XPlaneCommand FMS2CDUPopup { get { return new XPlaneCommand("sim/FMS2/CDU_popup", "FMS2: CDU popup"); } }
        public static XPlaneCommand AnnunciatorGearWarningMute { get { return new XPlaneCommand("sim/annunciator/gear_warning_mute", "Mute gear warning horn."); } }
        public static XPlaneCommand AnnunciatorMarkerBeaconMute { get { return new XPlaneCommand("sim/annunciator/marker_beacon_mute", "Mute marker beacons until next marker is received."); } }
        public static XPlaneCommand AnnunciatorMarkerBeaconMuteOrOff { get { return new XPlaneCommand("sim/annunciator/marker_beacon_mute_or_off", "Mute marker beacons until next marker is received or indefinitely if none is received right now."); } }
        public static XPlaneCommand AnnunciatorMarkerBeaconSensHi { get { return new XPlaneCommand("sim/annunciator/marker_beacon_sens_hi", "Marker beacon receiver hi sens."); } }
        public static XPlaneCommand AnnunciatorMarkerBeaconSensLo { get { return new XPlaneCommand("sim/annunciator/marker_beacon_sens_lo", "Marker beacon receiver lo sens."); } }
        public static XPlaneCommand AnnunciatorMarkerBeaconSensToggle { get { return new XPlaneCommand("sim/annunciator/marker_beacon_sens_toggle", "Marker beacon receiver sens toggle."); } }
        public static XPlaneCommand SystemsPreRotateToggle { get { return new XPlaneCommand("sim/systems/pre_rotate_toggle", "Toggle pre-rotate."); } }
        public static XPlaneCommand FlightControlsPumpFlaps { get { return new XPlaneCommand("sim/flight_controls/pump_flaps", "Pump flaps up/down."); } }
        public static XPlaneCommand FlightControlsPumpGear { get { return new XPlaneCommand("sim/flight_controls/pump_gear", "Pump gear up/down."); } }
        public static XPlaneCommand GPSModeAirport { get { return new XPlaneCommand("sim/GPS/mode_airport", "GPS mode: airports."); } }
        public static XPlaneCommand GPSModeVOR { get { return new XPlaneCommand("sim/GPS/mode_VOR", "GPS mode: VORs."); } }
        public static XPlaneCommand GPSModeNDB { get { return new XPlaneCommand("sim/GPS/mode_NDB", "GPS mode: NDBs."); } }
        public static XPlaneCommand GPSModeWaypoint { get { return new XPlaneCommand("sim/GPS/mode_waypoint", "GPS mode: waypoints."); } }
        public static XPlaneCommand GPSFineSelectDown { get { return new XPlaneCommand("sim/GPS/fine_select_down", "GPS fine select down."); } }
        public static XPlaneCommand GPSFineSelectUp { get { return new XPlaneCommand("sim/GPS/fine_select_up", "GPS fine select up."); } }
        public static XPlaneCommand GPSCoarseSelectDown { get { return new XPlaneCommand("sim/GPS/coarse_select_down", "GPS coarse select down."); } }
        public static XPlaneCommand GPSCoarseSelectUp { get { return new XPlaneCommand("sim/GPS/coarse_select_up", "GPS coarse select up."); } }
        public static XPlaneCommand GPSG430n1CoarseDown { get { return new XPlaneCommand("sim/GPS/g430n1_coarse_down", "GNS COM/NAV 1 coarse down."); } }
        public static XPlaneCommand GPSG430n1CoarseUp { get { return new XPlaneCommand("sim/GPS/g430n1_coarse_up", "GNS COM/NAV 1 coarse up."); } }
        public static XPlaneCommand GPSG430n1FineDown { get { return new XPlaneCommand("sim/GPS/g430n1_fine_down", "GNS COM/NAV 1 fine down."); } }
        public static XPlaneCommand GPSG430n1FineUp { get { return new XPlaneCommand("sim/GPS/g430n1_fine_up", "GNS COM/NAV 1 fine up."); } }
        public static XPlaneCommand GPSG430n1ChapterUp { get { return new XPlaneCommand("sim/GPS/g430n1_chapter_up", "GNS NAV 1 chapter up."); } }
        public static XPlaneCommand GPSG430n1ChapterDn { get { return new XPlaneCommand("sim/GPS/g430n1_chapter_dn", "GNS NAV 1 chapter dn."); } }
        public static XPlaneCommand GPSG430n1PageUp { get { return new XPlaneCommand("sim/GPS/g430n1_page_up", "GNS NAV 1 page up."); } }
        public static XPlaneCommand GPSG430n1PageDn { get { return new XPlaneCommand("sim/GPS/g430n1_page_dn", "GNS NAV 1 page dn."); } }
        public static XPlaneCommand GPSG430n1ZoomIn { get { return new XPlaneCommand("sim/GPS/g430n1_zoom_in", "GNS NAV 1 zoom in."); } }
        public static XPlaneCommand GPSG430n1ZoomOut { get { return new XPlaneCommand("sim/GPS/g430n1_zoom_out", "GNS NAV 1 zoom out."); } }
        public static XPlaneCommand GPSG430n1NavComTog { get { return new XPlaneCommand("sim/GPS/g430n1_nav_com_tog", "GNS NAV 1 NAV COM toggle."); } }
        public static XPlaneCommand GPSG430n1Cdi { get { return new XPlaneCommand("sim/GPS/g430n1_cdi", "GNS NAV 1 CDI."); } }
        public static XPlaneCommand GPSG430n1Obs { get { return new XPlaneCommand("sim/GPS/g430n1_obs", "GNS NAV 1 OBS."); } }
        public static XPlaneCommand GPSG430n1Msg { get { return new XPlaneCommand("sim/GPS/g430n1_msg", "GNS NAV 1 MSG."); } }
        public static XPlaneCommand GPSG430n1Fpl { get { return new XPlaneCommand("sim/GPS/g430n1_fpl", "GNS NAV 1 FPL."); } }
        public static XPlaneCommand GPSG430n1Proc { get { return new XPlaneCommand("sim/GPS/g430n1_proc", "GNS NAV 1 PROC."); } }
        public static XPlaneCommand GPSG430n1Vnav { get { return new XPlaneCommand("sim/GPS/g430n1_vnav", "GNS NAV 1 VNAV."); } }
        public static XPlaneCommand GPSG430n1Direct { get { return new XPlaneCommand("sim/GPS/g430n1_direct", "GNS NAV 1 Direct."); } }
        public static XPlaneCommand GPSG430n1Menu { get { return new XPlaneCommand("sim/GPS/g430n1_menu", "GNS NAV 1 Menu."); } }
        public static XPlaneCommand GPSG430n1Clr { get { return new XPlaneCommand("sim/GPS/g430n1_clr", "GNS NAV 1 CLR."); } }
        public static XPlaneCommand GPSG430n1Ent { get { return new XPlaneCommand("sim/GPS/g430n1_ent", "GNS NAV 1 ENT."); } }
        public static XPlaneCommand GPSG430n1ComFf { get { return new XPlaneCommand("sim/GPS/g430n1_com_ff", "GNS NAV 1 COM flip flop."); } }
        public static XPlaneCommand GPSG430n1NavFf { get { return new XPlaneCommand("sim/GPS/g430n1_nav_ff", "GNS NAV 1 NAV flip flop."); } }
        public static XPlaneCommand GPSG430n1Cursor { get { return new XPlaneCommand("sim/GPS/g430n1_cursor", "GNS NAV 1 push cursor."); } }
        public static XPlaneCommand GPSG430n1Popout { get { return new XPlaneCommand("sim/GPS/g430n1_popout", "GNS NAV 1 pop out window."); } }
        public static XPlaneCommand GPSG430n1Popup { get { return new XPlaneCommand("sim/GPS/g430n1_popup", "GNS NAV 1 toggle popup."); } }
        public static XPlaneCommand GPSG430n1Cvol { get { return new XPlaneCommand("sim/GPS/g430n1_cvol", "GNS NAV 1 COM audio."); } }
        public static XPlaneCommand GPSG430n1Vvol { get { return new XPlaneCommand("sim/GPS/g430n1_vvol", "GNS NAV 1 NAV ID"); } }
        public static XPlaneCommand GPSG430n1CvolUp { get { return new XPlaneCommand("sim/GPS/g430n1_cvol_up", "GNS NAV 1 COM audio volume up."); } }
        public static XPlaneCommand GPSG430n1CvolDn { get { return new XPlaneCommand("sim/GPS/g430n1_cvol_dn", "GNS NAV 1 COM audio volume down."); } }
        public static XPlaneCommand GPSG430n1VvolUp { get { return new XPlaneCommand("sim/GPS/g430n1_vvol_up", "GNS NAV 1 NAV audio volume up."); } }
        public static XPlaneCommand GPSG430n1VvolDn { get { return new XPlaneCommand("sim/GPS/g430n1_vvol_dn", "GNS NAV 1 NAV audio volume down."); } }
        public static XPlaneCommand GPSG430n2CoarseDown { get { return new XPlaneCommand("sim/GPS/g430n2_coarse_down", "GNS COM/NAV 2 coarse down."); } }
        public static XPlaneCommand GPSG430n2CoarseUp { get { return new XPlaneCommand("sim/GPS/g430n2_coarse_up", "GNS COM/NAV 2 coarse up."); } }
        public static XPlaneCommand GPSG430n2FineDown { get { return new XPlaneCommand("sim/GPS/g430n2_fine_down", "GNS COM/NAV 2 fine down."); } }
        public static XPlaneCommand GPSG430n2FineUp { get { return new XPlaneCommand("sim/GPS/g430n2_fine_up", "GNS COM/NAV 2 fine up."); } }
        public static XPlaneCommand GPSG430n2ChapterUp { get { return new XPlaneCommand("sim/GPS/g430n2_chapter_up", "GNS NAV 2 chapter up."); } }
        public static XPlaneCommand GPSG430n2ChapterDn { get { return new XPlaneCommand("sim/GPS/g430n2_chapter_dn", "GNS NAV 2 chapter dn."); } }
        public static XPlaneCommand GPSG430n2PageUp { get { return new XPlaneCommand("sim/GPS/g430n2_page_up", "GNS NAV 2 page up."); } }
        public static XPlaneCommand GPSG430n2PageDn { get { return new XPlaneCommand("sim/GPS/g430n2_page_dn", "GNS NAV 2 page dn."); } }
        public static XPlaneCommand GPSG430n2ZoomIn { get { return new XPlaneCommand("sim/GPS/g430n2_zoom_in", "GNS NAV 2 zoom in."); } }
        public static XPlaneCommand GPSG430n2ZoomOut { get { return new XPlaneCommand("sim/GPS/g430n2_zoom_out", "GNS NAV 2 zoom out."); } }
        public static XPlaneCommand GPSG430n2NavComTog { get { return new XPlaneCommand("sim/GPS/g430n2_nav_com_tog", "GNS NAV 2 NAV COM toggle."); } }
        public static XPlaneCommand GPSG430n2Cdi { get { return new XPlaneCommand("sim/GPS/g430n2_cdi", "GNS NAV 2 CDI."); } }
        public static XPlaneCommand GPSG430n2Obs { get { return new XPlaneCommand("sim/GPS/g430n2_obs", "GNS NAV 2 OBS."); } }
        public static XPlaneCommand GPSG430n2Msg { get { return new XPlaneCommand("sim/GPS/g430n2_msg", "GNS NAV 2 MSG."); } }
        public static XPlaneCommand GPSG430n2Fpl { get { return new XPlaneCommand("sim/GPS/g430n2_fpl", "GNS NAV 2 FPL."); } }
        public static XPlaneCommand GPSG430n2Proc { get { return new XPlaneCommand("sim/GPS/g430n2_proc", "GNS NAV 2 PROC."); } }
        public static XPlaneCommand GPSG430n2Vnav { get { return new XPlaneCommand("sim/GPS/g430n2_vnav", "GNS NAV 2 VNAV."); } }
        public static XPlaneCommand GPSG430n2Direct { get { return new XPlaneCommand("sim/GPS/g430n2_direct", "GNS NAV 2 Direct."); } }
        public static XPlaneCommand GPSG430n2Menu { get { return new XPlaneCommand("sim/GPS/g430n2_menu", "GNS NAV 2 Menu."); } }
        public static XPlaneCommand GPSG430n2Clr { get { return new XPlaneCommand("sim/GPS/g430n2_clr", "GNS NAV 2 CLR."); } }
        public static XPlaneCommand GPSG430n2Ent { get { return new XPlaneCommand("sim/GPS/g430n2_ent", "GNS NAV 2 ENT."); } }
        public static XPlaneCommand GPSG430n2ComFf { get { return new XPlaneCommand("sim/GPS/g430n2_com_ff", "GNS NAV 2 COM FF."); } }
        public static XPlaneCommand GPSG430n2NavFf { get { return new XPlaneCommand("sim/GPS/g430n2_nav_ff", "GNS NAV 2 NAV FF."); } }
        public static XPlaneCommand GPSG430n2Cursor { get { return new XPlaneCommand("sim/GPS/g430n2_cursor", "GNS NAV 2 push cursor."); } }
        public static XPlaneCommand GPSG430n2Popout { get { return new XPlaneCommand("sim/GPS/g430n2_popout", "GNS NAV 2 pop out window."); } }
        public static XPlaneCommand GPSG430n2Popup { get { return new XPlaneCommand("sim/GPS/g430n2_popup", "GNS NAV 2 toggle popup."); } }
        public static XPlaneCommand GPSG430n2Cvol { get { return new XPlaneCommand("sim/GPS/g430n2_cvol", "GNS NAV 2 COM audio."); } }
        public static XPlaneCommand GPSG430n2Vvol { get { return new XPlaneCommand("sim/GPS/g430n2_vvol", "GNS NAV 2 NAV ID"); } }
        public static XPlaneCommand GPSG430n2CvolUp { get { return new XPlaneCommand("sim/GPS/g430n2_cvol_up", "GNS NAV 2 COM audio volume up."); } }
        public static XPlaneCommand GPSG430n2CvolDn { get { return new XPlaneCommand("sim/GPS/g430n2_cvol_dn", "GNS NAV 2 COM audio volume down."); } }
        public static XPlaneCommand GPSG430n2VvolUp { get { return new XPlaneCommand("sim/GPS/g430n2_vvol_up", "GNS NAV 2 NAV audio volume up."); } }
        public static XPlaneCommand GPSG430n2VvolDn { get { return new XPlaneCommand("sim/GPS/g430n2_vvol_dn", "GNS NAV 2 NAV audio volume down."); } }
        public static XPlaneCommand GPSG1000n1Nvol { get { return new XPlaneCommand("sim/GPS/g1000n1_nvol", "G1000 pilot NAV audio."); } }
        public static XPlaneCommand GPSG1000n1NvolUp { get { return new XPlaneCommand("sim/GPS/g1000n1_nvol_up", "G1000 pilot NAV audio volume up."); } }
        public static XPlaneCommand GPSG1000n1NvolDn { get { return new XPlaneCommand("sim/GPS/g1000n1_nvol_dn", "G1000 pilot NAV audio volume down."); } }
        public static XPlaneCommand GPSG1000n1NavFf { get { return new XPlaneCommand("sim/GPS/g1000n1_nav_ff", "G1000 pilot NAV flip flop."); } }
        public static XPlaneCommand GPSG1000n1NavOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n1_nav_outer_up", "G1000 pilot NAV outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n1NavOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n1_nav_outer_down", "G1000 pilot NAV outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n1NavInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n1_nav_inner_up", "G1000 pilot NAV inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n1NavInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n1_nav_inner_down", "G1000 pilot NAV inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n1Nav12 { get { return new XPlaneCommand("sim/GPS/g1000n1_nav12", "G1000 pilot PFD NAV 1/2."); } }
        public static XPlaneCommand GPSG1000n1HdgUp { get { return new XPlaneCommand("sim/GPS/g1000n1_hdg_up", "G1000 pilot HDG up."); } }
        public static XPlaneCommand GPSG1000n1HdgDown { get { return new XPlaneCommand("sim/GPS/g1000n1_hdg_down", "G1000 pilot HDG down."); } }
        public static XPlaneCommand GPSG1000n1HdgSync { get { return new XPlaneCommand("sim/GPS/g1000n1_hdg_sync", "G1000 pilot HDG sync."); } }
        public static XPlaneCommand GPSG1000n1Ap { get { return new XPlaneCommand("sim/GPS/g1000n1_ap", "G1000 pilot autopilot."); } }
        public static XPlaneCommand GPSG1000n1Fd { get { return new XPlaneCommand("sim/GPS/g1000n1_fd", "G1000 pilot flight director."); } }
        public static XPlaneCommand GPSG1000n1Yd { get { return new XPlaneCommand("sim/GPS/g1000n1_yd", "G1000 pilot yaw damper."); } }
        public static XPlaneCommand GPSG1000n1Hdg { get { return new XPlaneCommand("sim/GPS/g1000n1_hdg", "G1000 pilot AP HDG."); } }
        public static XPlaneCommand GPSG1000n1Alt { get { return new XPlaneCommand("sim/GPS/g1000n1_alt", "G1000 pilot AP ALT."); } }
        public static XPlaneCommand GPSG1000n1Nav { get { return new XPlaneCommand("sim/GPS/g1000n1_nav", "G1000 pilot AP NAV."); } }
        public static XPlaneCommand GPSG1000n1Vnv { get { return new XPlaneCommand("sim/GPS/g1000n1_vnv", "G1000 pilot AP VNAV."); } }
        public static XPlaneCommand GPSG1000n1Apr { get { return new XPlaneCommand("sim/GPS/g1000n1_apr", "G1000 pilot AP approach."); } }
        public static XPlaneCommand GPSG1000n1Bc { get { return new XPlaneCommand("sim/GPS/g1000n1_bc", "G1000 pilot AP backcourse."); } }
        public static XPlaneCommand GPSG1000n1Vs { get { return new XPlaneCommand("sim/GPS/g1000n1_vs", "G1000 pilot AP vertical speed."); } }
        public static XPlaneCommand GPSG1000n1Flc { get { return new XPlaneCommand("sim/GPS/g1000n1_flc", "G1000 pilot AP flight level change."); } }
        public static XPlaneCommand GPSG1000n1NoseUp { get { return new XPlaneCommand("sim/GPS/g1000n1_nose_up", "G1000 pilot AP nose up."); } }
        public static XPlaneCommand GPSG1000n1NoseDown { get { return new XPlaneCommand("sim/GPS/g1000n1_nose_down", "G1000 pilot AP nose down."); } }
        public static XPlaneCommand GPSG1000n1AltOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n1_alt_outer_up", "G1000 pilot altitude outer ring up."); } }
        public static XPlaneCommand GPSG1000n1AltOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n1_alt_outer_down", "G1000 pilot altitude outer ring down."); } }
        public static XPlaneCommand GPSG1000n1AltInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n1_alt_inner_up", "G1000 pilot altitude inner ring up."); } }
        public static XPlaneCommand GPSG1000n1AltInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n1_alt_inner_down", "G1000 pilot altitude inner ring down."); } }
        public static XPlaneCommand GPSG1000n1Softkey1 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey1", "G1000 pilot PFD Softkey 1."); } }
        public static XPlaneCommand GPSG1000n1Softkey2 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey2", "G1000 pilot PFD Softkey 2."); } }
        public static XPlaneCommand GPSG1000n1Softkey3 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey3", "G1000 pilot PFD Softkey 3."); } }
        public static XPlaneCommand GPSG1000n1Softkey4 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey4", "G1000 pilot PFD Softkey 4."); } }
        public static XPlaneCommand GPSG1000n1Softkey5 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey5", "G1000 pilot PFD Softkey 5."); } }
        public static XPlaneCommand GPSG1000n1Softkey6 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey6", "G1000 pilot PFD Softkey 6."); } }
        public static XPlaneCommand GPSG1000n1Softkey7 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey7", "G1000 pilot PFD Softkey 7."); } }
        public static XPlaneCommand GPSG1000n1Softkey8 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey8", "G1000 pilot PFD Softkey 8."); } }
        public static XPlaneCommand GPSG1000n1Softkey9 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey9", "G1000 pilot PFD Softkey 9."); } }
        public static XPlaneCommand GPSG1000n1Softkey10 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey10", "G1000 pilot PFD Softkey 10."); } }
        public static XPlaneCommand GPSG1000n1Softkey11 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey11", "G1000 pilot PFD Softkey 11."); } }
        public static XPlaneCommand GPSG1000n1Softkey12 { get { return new XPlaneCommand("sim/GPS/g1000n1_softkey12", "G1000 pilot PFD Softkey 12."); } }
        public static XPlaneCommand GPSG1000n1Cvol { get { return new XPlaneCommand("sim/GPS/g1000n1_cvol", "G1000 pilot COM audio."); } }
        public static XPlaneCommand GPSG1000n1CvolUp { get { return new XPlaneCommand("sim/GPS/g1000n1_cvol_up", "G1000 pilot COM audio volume up."); } }
        public static XPlaneCommand GPSG1000n1CvolDn { get { return new XPlaneCommand("sim/GPS/g1000n1_cvol_dn", "G1000 pilot COM audio volume down."); } }
        public static XPlaneCommand GPSG1000n1ComFf { get { return new XPlaneCommand("sim/GPS/g1000n1_com_ff", "G1000 pilot COM flip flop."); } }
        public static XPlaneCommand GPSG1000n1ComOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n1_com_outer_up", "G1000 pilot COM outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n1ComOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n1_com_outer_down", "G1000 pilot COM outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n1ComInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n1_com_inner_up", "G1000 pilot COM inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n1ComInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n1_com_inner_down", "G1000 pilot COM inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n1Com12 { get { return new XPlaneCommand("sim/GPS/g1000n1_com12", "G1000 pilot PFD Com 1/2."); } }
        public static XPlaneCommand GPSG1000n1CrsUp { get { return new XPlaneCommand("sim/GPS/g1000n1_crs_up", "G1000 pilot CRS up."); } }
        public static XPlaneCommand GPSG1000n1CrsDown { get { return new XPlaneCommand("sim/GPS/g1000n1_crs_down", "G1000 pilot CRS down."); } }
        public static XPlaneCommand GPSG1000n1CrsSync { get { return new XPlaneCommand("sim/GPS/g1000n1_crs_sync", "G1000 pilot CRS sync."); } }
        public static XPlaneCommand GPSG1000n1BaroUp { get { return new XPlaneCommand("sim/GPS/g1000n1_baro_up", "G1000 pilot baro up."); } }
        public static XPlaneCommand GPSG1000n1BaroDown { get { return new XPlaneCommand("sim/GPS/g1000n1_baro_down", "G1000 pilot baro down."); } }
        public static XPlaneCommand GPSG1000n1RangeUp { get { return new XPlaneCommand("sim/GPS/g1000n1_range_up", "G1000 pilot range up."); } }
        public static XPlaneCommand GPSG1000n1RangeDown { get { return new XPlaneCommand("sim/GPS/g1000n1_range_down", "G1000 pilot range down."); } }
        public static XPlaneCommand GPSG1000n1PanUp { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_up", "G1000 pilot pan up."); } }
        public static XPlaneCommand GPSG1000n1PanDown { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_down", "G1000 pilot pan down."); } }
        public static XPlaneCommand GPSG1000n1PanLeft { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_left", "G1000 pilot pan left."); } }
        public static XPlaneCommand GPSG1000n1PanRight { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_right", "G1000 pilot pan right."); } }
        public static XPlaneCommand GPSG1000n1PanUpLeft { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_up_left", "G1000 pilot pan up left."); } }
        public static XPlaneCommand GPSG1000n1PanDownLeft { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_down_left", "G1000 pilot pan down left."); } }
        public static XPlaneCommand GPSG1000n1PanUpRight { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_up_right", "G1000 pilot pan up right."); } }
        public static XPlaneCommand GPSG1000n1PanDownRight { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_down_right", "G1000 pilot pan down right."); } }
        public static XPlaneCommand GPSG1000n1PanPush { get { return new XPlaneCommand("sim/GPS/g1000n1_pan_push", "G1000 pilot push pan."); } }
        public static XPlaneCommand GPSG1000n1Direct { get { return new XPlaneCommand("sim/GPS/g1000n1_direct", "G1000 pilot -D->."); } }
        public static XPlaneCommand GPSG1000n1Menu { get { return new XPlaneCommand("sim/GPS/g1000n1_menu", "G1000 pilot menu."); } }
        public static XPlaneCommand GPSG1000n1Fpl { get { return new XPlaneCommand("sim/GPS/g1000n1_fpl", "G1000 pilot FPL."); } }
        public static XPlaneCommand GPSG1000n1Proc { get { return new XPlaneCommand("sim/GPS/g1000n1_proc", "G1000 pilot proc."); } }
        public static XPlaneCommand GPSG1000n1Clr { get { return new XPlaneCommand("sim/GPS/g1000n1_clr", "G1000 pilot CLR."); } }
        public static XPlaneCommand GPSG1000n1Ent { get { return new XPlaneCommand("sim/GPS/g1000n1_ent", "G1000 pilot ENT."); } }
        public static XPlaneCommand GPSG1000n1FmsOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n1_fms_outer_up", "G1000 pilot FMS outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n1FmsOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n1_fms_outer_down", "G1000 pilot FMS outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n1FmsInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n1_fms_inner_up", "G1000 pilot FMS inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n1FmsInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n1_fms_inner_down", "G1000 pilot FMS inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n1Cursor { get { return new XPlaneCommand("sim/GPS/g1000n1_cursor", "G1000 pilot FMS cursor."); } }
        public static XPlaneCommand GPSG1000n1Popout { get { return new XPlaneCommand("sim/GPS/g1000n1_popout", "G1000 pilot pop out window."); } }
        public static XPlaneCommand GPSG1000n1Popup { get { return new XPlaneCommand("sim/GPS/g1000n1_popup", "G1000 pilot popup."); } }
        public static XPlaneCommand GPSG1000n2Nvol { get { return new XPlaneCommand("sim/GPS/g1000n2_nvol", "G1000 copilot NAV audio."); } }
        public static XPlaneCommand GPSG1000n2NvolUp { get { return new XPlaneCommand("sim/GPS/g1000n2_nvol_up", "G1000 copilot NAV audio volume up."); } }
        public static XPlaneCommand GPSG1000n2NvolDn { get { return new XPlaneCommand("sim/GPS/g1000n2_nvol_dn", "G1000 copilot NAV audio volume down."); } }
        public static XPlaneCommand GPSG1000n2NavFf { get { return new XPlaneCommand("sim/GPS/g1000n2_nav_ff", "G1000 copilot NAV flip flop."); } }
        public static XPlaneCommand GPSG1000n2NavOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n2_nav_outer_up", "G1000 copilot NAV outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n2NavOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n2_nav_outer_down", "G1000 copilot NAV outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n2NavInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n2_nav_inner_up", "G1000 copilot NAV inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n2NavInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n2_nav_inner_down", "G1000 copilot NAV inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n2Nav12 { get { return new XPlaneCommand("sim/GPS/g1000n2_nav12", "G1000 copilot PFD NAV 1/2."); } }
        public static XPlaneCommand GPSG1000n2HdgUp { get { return new XPlaneCommand("sim/GPS/g1000n2_hdg_up", "G1000 copilot HDG up."); } }
        public static XPlaneCommand GPSG1000n2HdgDown { get { return new XPlaneCommand("sim/GPS/g1000n2_hdg_down", "G1000 copilot HDG down."); } }
        public static XPlaneCommand GPSG1000n2HdgSync { get { return new XPlaneCommand("sim/GPS/g1000n2_hdg_sync", "G1000 copilot HDG sync."); } }
        public static XPlaneCommand GPSG1000n2Ap { get { return new XPlaneCommand("sim/GPS/g1000n2_ap", "G1000 copilot autopilot."); } }
        public static XPlaneCommand GPSG1000n2Fd { get { return new XPlaneCommand("sim/GPS/g1000n2_fd", "G1000 copilot flight director."); } }
        public static XPlaneCommand GPSG1000n2Yd { get { return new XPlaneCommand("sim/GPS/g1000n2_yd", "G1000 copilot yaw damper."); } }
        public static XPlaneCommand GPSG1000n2Hdg { get { return new XPlaneCommand("sim/GPS/g1000n2_hdg", "G1000 copilot AP HDG."); } }
        public static XPlaneCommand GPSG1000n2Alt { get { return new XPlaneCommand("sim/GPS/g1000n2_alt", "G1000 copilot AP ALT."); } }
        public static XPlaneCommand GPSG1000n2Nav { get { return new XPlaneCommand("sim/GPS/g1000n2_nav", "G1000 copilot AP NAV."); } }
        public static XPlaneCommand GPSG1000n2Vnv { get { return new XPlaneCommand("sim/GPS/g1000n2_vnv", "G1000 copilot AP VNAV."); } }
        public static XPlaneCommand GPSG1000n2Apr { get { return new XPlaneCommand("sim/GPS/g1000n2_apr", "G1000 copilot AP approach."); } }
        public static XPlaneCommand GPSG1000n2Bc { get { return new XPlaneCommand("sim/GPS/g1000n2_bc", "G1000 copilot AP backcourse."); } }
        public static XPlaneCommand GPSG1000n2Vs { get { return new XPlaneCommand("sim/GPS/g1000n2_vs", "G1000 copilot AP vertical speed."); } }
        public static XPlaneCommand GPSG1000n2Flc { get { return new XPlaneCommand("sim/GPS/g1000n2_flc", "G1000 copilot AP flight level change."); } }
        public static XPlaneCommand GPSG1000n2NoseUp { get { return new XPlaneCommand("sim/GPS/g1000n2_nose_up", "G1000 copilot AP nose up."); } }
        public static XPlaneCommand GPSG1000n2NoseDown { get { return new XPlaneCommand("sim/GPS/g1000n2_nose_down", "G1000 copilot AP nose down."); } }
        public static XPlaneCommand GPSG1000n2AltOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n2_alt_outer_up", "G1000 copilot altitude outer ring up."); } }
        public static XPlaneCommand GPSG1000n2AltOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n2_alt_outer_down", "G1000 copilot altitude outer ring down."); } }
        public static XPlaneCommand GPSG1000n2AltInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n2_alt_inner_up", "G1000 copilot altitude inner ring up."); } }
        public static XPlaneCommand GPSG1000n2AltInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n2_alt_inner_down", "G1000 copilot altitude inner ring down."); } }
        public static XPlaneCommand GPSG1000n2Softkey1 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey1", "G1000 copilot PFD Softkey 1."); } }
        public static XPlaneCommand GPSG1000n2Softkey2 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey2", "G1000 copilot PFD Softkey 2."); } }
        public static XPlaneCommand GPSG1000n2Softkey3 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey3", "G1000 copilot PFD Softkey 3."); } }
        public static XPlaneCommand GPSG1000n2Softkey4 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey4", "G1000 copilot PFD Softkey 4."); } }
        public static XPlaneCommand GPSG1000n2Softkey5 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey5", "G1000 copilot PFD Softkey 5."); } }
        public static XPlaneCommand GPSG1000n2Softkey6 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey6", "G1000 copilot PFD Softkey 6."); } }
        public static XPlaneCommand GPSG1000n2Softkey7 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey7", "G1000 copilot PFD Softkey 7."); } }
        public static XPlaneCommand GPSG1000n2Softkey8 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey8", "G1000 copilot PFD Softkey 8."); } }
        public static XPlaneCommand GPSG1000n2Softkey9 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey9", "G1000 copilot PFD Softkey 9."); } }
        public static XPlaneCommand GPSG1000n2Softkey10 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey10", "G1000 copilot PFD Softkey 10."); } }
        public static XPlaneCommand GPSG1000n2Softkey11 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey11", "G1000 copilot PFD Softkey 11."); } }
        public static XPlaneCommand GPSG1000n2Softkey12 { get { return new XPlaneCommand("sim/GPS/g1000n2_softkey12", "G1000 copilot PFD Softkey 12."); } }
        public static XPlaneCommand GPSG1000n2Cvol { get { return new XPlaneCommand("sim/GPS/g1000n2_cvol", "G1000 copilot COM audio."); } }
        public static XPlaneCommand GPSG1000n2CvolUp { get { return new XPlaneCommand("sim/GPS/g1000n2_cvol_up", "G1000 copilot COM audio volume up."); } }
        public static XPlaneCommand GPSG1000n2CvolDn { get { return new XPlaneCommand("sim/GPS/g1000n2_cvol_dn", "G1000 copilot COM audio volume down."); } }
        public static XPlaneCommand GPSG1000n2ComFf { get { return new XPlaneCommand("sim/GPS/g1000n2_com_ff", "G1000 copilot COM flip flop."); } }
        public static XPlaneCommand GPSG1000n2ComOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n2_com_outer_up", "G1000 copilot COM outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n2ComOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n2_com_outer_down", "G1000 copilot COM outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n2ComInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n2_com_inner_up", "G1000 copilot COM inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n2ComInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n2_com_inner_down", "G1000 copilot COM inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n2Com12 { get { return new XPlaneCommand("sim/GPS/g1000n2_com12", "G1000 copilot PFD Com 1/2."); } }
        public static XPlaneCommand GPSG1000n2CrsUp { get { return new XPlaneCommand("sim/GPS/g1000n2_crs_up", "G1000 copilot CRS up."); } }
        public static XPlaneCommand GPSG1000n2CrsDown { get { return new XPlaneCommand("sim/GPS/g1000n2_crs_down", "G1000 copilot CRS down."); } }
        public static XPlaneCommand GPSG1000n2CrsSync { get { return new XPlaneCommand("sim/GPS/g1000n2_crs_sync", "G1000 copilot CRS sync."); } }
        public static XPlaneCommand GPSG1000n2BaroUp { get { return new XPlaneCommand("sim/GPS/g1000n2_baro_up", "G1000 copilot baro up."); } }
        public static XPlaneCommand GPSG1000n2BaroDown { get { return new XPlaneCommand("sim/GPS/g1000n2_baro_down", "G1000 copilot baro down."); } }
        public static XPlaneCommand GPSG1000n2RangeUp { get { return new XPlaneCommand("sim/GPS/g1000n2_range_up", "G1000 copilot range up."); } }
        public static XPlaneCommand GPSG1000n2RangeDown { get { return new XPlaneCommand("sim/GPS/g1000n2_range_down", "G1000 copilot range down."); } }
        public static XPlaneCommand GPSG1000n2PanUp { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_up", "G1000 copilot pan up."); } }
        public static XPlaneCommand GPSG1000n2PanDown { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_down", "G1000 copilot pan down."); } }
        public static XPlaneCommand GPSG1000n2PanLeft { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_left", "G1000 copilot pan left."); } }
        public static XPlaneCommand GPSG1000n2PanRight { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_right", "G1000 copilot pan right."); } }
        public static XPlaneCommand GPSG1000n2PanUpLeft { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_up_left", "G1000 copilot pan up left."); } }
        public static XPlaneCommand GPSG1000n2PanDownLeft { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_down_left", "G1000 copilot pan down left."); } }
        public static XPlaneCommand GPSG1000n2PanUpRight { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_up_right", "G1000 copilot pan up right."); } }
        public static XPlaneCommand GPSG1000n2PanDownRight { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_down_right", "G1000 copilot pan down right."); } }
        public static XPlaneCommand GPSG1000n2PanPush { get { return new XPlaneCommand("sim/GPS/g1000n2_pan_push", "G1000 copilot push pan."); } }
        public static XPlaneCommand GPSG1000n2Direct { get { return new XPlaneCommand("sim/GPS/g1000n2_direct", "G1000 copilot -D->."); } }
        public static XPlaneCommand GPSG1000n2Menu { get { return new XPlaneCommand("sim/GPS/g1000n2_menu", "G1000 copilot menu."); } }
        public static XPlaneCommand GPSG1000n2Fpl { get { return new XPlaneCommand("sim/GPS/g1000n2_fpl", "G1000 copilot FPL."); } }
        public static XPlaneCommand GPSG1000n2Proc { get { return new XPlaneCommand("sim/GPS/g1000n2_proc", "G1000 copilot proc."); } }
        public static XPlaneCommand GPSG1000n2Clr { get { return new XPlaneCommand("sim/GPS/g1000n2_clr", "G1000 copilot CLR."); } }
        public static XPlaneCommand GPSG1000n2Ent { get { return new XPlaneCommand("sim/GPS/g1000n2_ent", "G1000 copilot ENT."); } }
        public static XPlaneCommand GPSG1000n2FmsOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n2_fms_outer_up", "G1000 copilot FMS outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n2FmsOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n2_fms_outer_down", "G1000 copilot FMS outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n2FmsInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n2_fms_inner_up", "G1000 copilot FMS inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n2FmsInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n2_fms_inner_down", "G1000 copilot FMS inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n2Cursor { get { return new XPlaneCommand("sim/GPS/g1000n2_cursor", "G1000 copilot FMS cursor."); } }
        public static XPlaneCommand GPSG1000n2Popout { get { return new XPlaneCommand("sim/GPS/g1000n2_popout", "G1000 copilot pop out window."); } }
        public static XPlaneCommand GPSG1000n2Popup { get { return new XPlaneCommand("sim/GPS/g1000n2_popup", "G1000 copilot popup."); } }
        public static XPlaneCommand GPSG1000n3Nvol { get { return new XPlaneCommand("sim/GPS/g1000n3_nvol", "G1000 MFD NAV audio."); } }
        public static XPlaneCommand GPSG1000n3NvolUp { get { return new XPlaneCommand("sim/GPS/g1000n3_nvol_up", "G1000 MFD NAV audio volume up."); } }
        public static XPlaneCommand GPSG1000n3NvolDn { get { return new XPlaneCommand("sim/GPS/g1000n3_nvol_dn", "G1000 MFD NAV audio volume down."); } }
        public static XPlaneCommand GPSG1000n3NavFf { get { return new XPlaneCommand("sim/GPS/g1000n3_nav_ff", "G1000 MFD NAV flip flop."); } }
        public static XPlaneCommand GPSG1000n3NavOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n3_nav_outer_up", "G1000 MFD NAV outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n3NavOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n3_nav_outer_down", "G1000 MFD NAV outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n3NavInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n3_nav_inner_up", "G1000 MFD NAV inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n3NavInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n3_nav_inner_down", "G1000 MFD NAV inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n3Nav12 { get { return new XPlaneCommand("sim/GPS/g1000n3_nav12", "G1000 MFD NAV 1/2."); } }
        public static XPlaneCommand GPSG1000n3HdgUp { get { return new XPlaneCommand("sim/GPS/g1000n3_hdg_up", "G1000 MFD HDG up."); } }
        public static XPlaneCommand GPSG1000n3HdgDown { get { return new XPlaneCommand("sim/GPS/g1000n3_hdg_down", "G1000 MFD HDG down."); } }
        public static XPlaneCommand GPSG1000n3HdgSync { get { return new XPlaneCommand("sim/GPS/g1000n3_hdg_sync", "G1000 MFD HDG sync."); } }
        public static XPlaneCommand GPSG1000n3Ap { get { return new XPlaneCommand("sim/GPS/g1000n3_ap", "G1000 MFD autopilot."); } }
        public static XPlaneCommand GPSG1000n3Fd { get { return new XPlaneCommand("sim/GPS/g1000n3_fd", "G1000 MFD flight director."); } }
        public static XPlaneCommand GPSG1000n3Yd { get { return new XPlaneCommand("sim/GPS/g1000n3_yd", "G1000 MFD yaw damper."); } }
        public static XPlaneCommand GPSG1000n3Hdg { get { return new XPlaneCommand("sim/GPS/g1000n3_hdg", "G1000 MFD AP HDG."); } }
        public static XPlaneCommand GPSG1000n3Alt { get { return new XPlaneCommand("sim/GPS/g1000n3_alt", "G1000 MFD AP ALT."); } }
        public static XPlaneCommand GPSG1000n3Nav { get { return new XPlaneCommand("sim/GPS/g1000n3_nav", "G1000 MFD AP NAV."); } }
        public static XPlaneCommand GPSG1000n3Vnv { get { return new XPlaneCommand("sim/GPS/g1000n3_vnv", "G1000 MFD AP VNAV."); } }
        public static XPlaneCommand GPSG1000n3Apr { get { return new XPlaneCommand("sim/GPS/g1000n3_apr", "G1000 MFD AP approach."); } }
        public static XPlaneCommand GPSG1000n3Bc { get { return new XPlaneCommand("sim/GPS/g1000n3_bc", "G1000 MFD AP backcourse."); } }
        public static XPlaneCommand GPSG1000n3Vs { get { return new XPlaneCommand("sim/GPS/g1000n3_vs", "G1000 MFD AP vertical speed."); } }
        public static XPlaneCommand GPSG1000n3Flc { get { return new XPlaneCommand("sim/GPS/g1000n3_flc", "G1000 MFD AP flight level change."); } }
        public static XPlaneCommand GPSG1000n3NoseUp { get { return new XPlaneCommand("sim/GPS/g1000n3_nose_up", "G1000 MFD AP nose up."); } }
        public static XPlaneCommand GPSG1000n3NoseDown { get { return new XPlaneCommand("sim/GPS/g1000n3_nose_down", "G1000 MFD AP nose down."); } }
        public static XPlaneCommand GPSG1000n3AltOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n3_alt_outer_up", "G1000 MFD altitude outer ring up."); } }
        public static XPlaneCommand GPSG1000n3AltOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n3_alt_outer_down", "G1000 MFD altitude outer ring down."); } }
        public static XPlaneCommand GPSG1000n3AltInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n3_alt_inner_up", "G1000 MFD altitude inner ring up."); } }
        public static XPlaneCommand GPSG1000n3AltInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n3_alt_inner_down", "G1000 MFD altitude inner ring down."); } }
        public static XPlaneCommand GPSG1000n3Softkey1 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey1", "G1000 MFD Softkey 1."); } }
        public static XPlaneCommand GPSG1000n3Softkey2 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey2", "G1000 MFD Softkey 2."); } }
        public static XPlaneCommand GPSG1000n3Softkey3 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey3", "G1000 MFD Softkey 3."); } }
        public static XPlaneCommand GPSG1000n3Softkey4 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey4", "G1000 MFD Softkey 4."); } }
        public static XPlaneCommand GPSG1000n3Softkey5 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey5", "G1000 MFD Softkey 5."); } }
        public static XPlaneCommand GPSG1000n3Softkey6 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey6", "G1000 MFD Softkey 6."); } }
        public static XPlaneCommand GPSG1000n3Softkey7 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey7", "G1000 MFD Softkey 7."); } }
        public static XPlaneCommand GPSG1000n3Softkey8 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey8", "G1000 MFD Softkey 8."); } }
        public static XPlaneCommand GPSG1000n3Softkey9 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey9", "G1000 MFD Softkey 9."); } }
        public static XPlaneCommand GPSG1000n3Softkey10 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey10", "G1000 MFD Softkey 10."); } }
        public static XPlaneCommand GPSG1000n3Softkey11 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey11", "G1000 MFD Softkey 11."); } }
        public static XPlaneCommand GPSG1000n3Softkey12 { get { return new XPlaneCommand("sim/GPS/g1000n3_softkey12", "G1000 MFD Softkey 12."); } }
        public static XPlaneCommand GPSG1000n3Cvol { get { return new XPlaneCommand("sim/GPS/g1000n3_cvol", "G1000 MFD COM audio."); } }
        public static XPlaneCommand GPSG1000n3CvolUp { get { return new XPlaneCommand("sim/GPS/g1000n3_cvol_up", "G1000 MFD COM audio volume up."); } }
        public static XPlaneCommand GPSG1000n3CvolDn { get { return new XPlaneCommand("sim/GPS/g1000n3_cvol_dn", "G1000 MFD COM audio volume down."); } }
        public static XPlaneCommand GPSG1000n3ComFf { get { return new XPlaneCommand("sim/GPS/g1000n3_com_ff", "G1000 MFD COM flip flop."); } }
        public static XPlaneCommand GPSG1000n3ComOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n3_com_outer_up", "G1000 MFD COM outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n3ComOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n3_com_outer_down", "G1000 MFD COM outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n3ComInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n3_com_inner_up", "G1000 MFD COM inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n3ComInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n3_com_inner_down", "G1000 MFD COM inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n3Com12 { get { return new XPlaneCommand("sim/GPS/g1000n3_com12", "G1000 MFD COM 1/2."); } }
        public static XPlaneCommand GPSG1000n3CrsUp { get { return new XPlaneCommand("sim/GPS/g1000n3_crs_up", "G1000 MFD CRS up."); } }
        public static XPlaneCommand GPSG1000n3CrsDown { get { return new XPlaneCommand("sim/GPS/g1000n3_crs_down", "G1000 MFD CRS down."); } }
        public static XPlaneCommand GPSG1000n3CrsSync { get { return new XPlaneCommand("sim/GPS/g1000n3_crs_sync", "G1000 MFD CRS sync."); } }
        public static XPlaneCommand GPSG1000n3BaroUp { get { return new XPlaneCommand("sim/GPS/g1000n3_baro_up", "G1000 MFD baro up."); } }
        public static XPlaneCommand GPSG1000n3BaroDown { get { return new XPlaneCommand("sim/GPS/g1000n3_baro_down", "G1000 MFD baro down."); } }
        public static XPlaneCommand GPSG1000n3RangeUp { get { return new XPlaneCommand("sim/GPS/g1000n3_range_up", "G1000 MFD range up."); } }
        public static XPlaneCommand GPSG1000n3RangeDown { get { return new XPlaneCommand("sim/GPS/g1000n3_range_down", "G1000 MFD range down."); } }
        public static XPlaneCommand GPSG1000n3PanUp { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_up", "G1000 MFD pan up."); } }
        public static XPlaneCommand GPSG1000n3PanDown { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_down", "G1000 MFD pan down."); } }
        public static XPlaneCommand GPSG1000n3PanLeft { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_left", "G1000 MFD pan left."); } }
        public static XPlaneCommand GPSG1000n3PanRight { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_right", "G1000 MFD pan right."); } }
        public static XPlaneCommand GPSG1000n3PanUpLeft { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_up_left", "G1000 MFD pan up left."); } }
        public static XPlaneCommand GPSG1000n3PanDownLeft { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_down_left", "G1000 MFD pan down left."); } }
        public static XPlaneCommand GPSG1000n3PanUpRight { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_up_right", "G1000 MFD pan up right."); } }
        public static XPlaneCommand GPSG1000n3PanDownRight { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_down_right", "G1000 MFD pan down right."); } }
        public static XPlaneCommand GPSG1000n3PanPush { get { return new XPlaneCommand("sim/GPS/g1000n3_pan_push", "G1000 MFD push pan."); } }
        public static XPlaneCommand GPSG1000n3Direct { get { return new XPlaneCommand("sim/GPS/g1000n3_direct", "G1000 MFD -D->."); } }
        public static XPlaneCommand GPSG1000n3Menu { get { return new XPlaneCommand("sim/GPS/g1000n3_menu", "G1000 MFD menu."); } }
        public static XPlaneCommand GPSG1000n3Fpl { get { return new XPlaneCommand("sim/GPS/g1000n3_fpl", "G1000 MFD FPL."); } }
        public static XPlaneCommand GPSG1000n3Proc { get { return new XPlaneCommand("sim/GPS/g1000n3_proc", "G1000 MFD proc."); } }
        public static XPlaneCommand GPSG1000n3Clr { get { return new XPlaneCommand("sim/GPS/g1000n3_clr", "G1000 MFD CLR."); } }
        public static XPlaneCommand GPSG1000n3Ent { get { return new XPlaneCommand("sim/GPS/g1000n3_ent", "G1000 MFD ENT."); } }
        public static XPlaneCommand GPSG1000n3FmsOuterUp { get { return new XPlaneCommand("sim/GPS/g1000n3_fms_outer_up", "G1000 MFD FMS outer ring tune up."); } }
        public static XPlaneCommand GPSG1000n3FmsOuterDown { get { return new XPlaneCommand("sim/GPS/g1000n3_fms_outer_down", "G1000 MFD FMS outer ring tune down."); } }
        public static XPlaneCommand GPSG1000n3FmsInnerUp { get { return new XPlaneCommand("sim/GPS/g1000n3_fms_inner_up", "G1000 MFD FMS inner ring tune up."); } }
        public static XPlaneCommand GPSG1000n3FmsInnerDown { get { return new XPlaneCommand("sim/GPS/g1000n3_fms_inner_down", "G1000 MFD FMS inner ring tune down."); } }
        public static XPlaneCommand GPSG1000n3Cursor { get { return new XPlaneCommand("sim/GPS/g1000n3_cursor", "G1000 MFD FMS cursor."); } }
        public static XPlaneCommand GPSG1000n3Popout { get { return new XPlaneCommand("sim/GPS/g1000n3_popout", "G1000 MFD pop out window."); } }
        public static XPlaneCommand GPSG1000n3Popup { get { return new XPlaneCommand("sim/GPS/g1000n3_popup", "G1000 MFD popup."); } }
        public static XPlaneCommand GPSGcu478A { get { return new XPlaneCommand("sim/GPS/gcu478/A", "GCU: A"); } }
        public static XPlaneCommand GPSGcu478B { get { return new XPlaneCommand("sim/GPS/gcu478/B", "GCU: B"); } }
        public static XPlaneCommand GPSGcu478C { get { return new XPlaneCommand("sim/GPS/gcu478/C", "GCU: C"); } }
        public static XPlaneCommand GPSGcu478D { get { return new XPlaneCommand("sim/GPS/gcu478/D", "GCU: D"); } }
        public static XPlaneCommand GPSGcu478E { get { return new XPlaneCommand("sim/GPS/gcu478/E", "GCU: E"); } }
        public static XPlaneCommand GPSGcu478F { get { return new XPlaneCommand("sim/GPS/gcu478/F", "GCU: F"); } }
        public static XPlaneCommand GPSGcu478G { get { return new XPlaneCommand("sim/GPS/gcu478/G", "GCU: G"); } }
        public static XPlaneCommand GPSGcu478H { get { return new XPlaneCommand("sim/GPS/gcu478/H", "GCU: H"); } }
        public static XPlaneCommand GPSGcu478I { get { return new XPlaneCommand("sim/GPS/gcu478/I", "GCU: I"); } }
        public static XPlaneCommand GPSGcu478J { get { return new XPlaneCommand("sim/GPS/gcu478/J", "GCU: J"); } }
        public static XPlaneCommand GPSGcu478K { get { return new XPlaneCommand("sim/GPS/gcu478/K", "GCU: K"); } }
        public static XPlaneCommand GPSGcu478L { get { return new XPlaneCommand("sim/GPS/gcu478/L", "GCU: L"); } }
        public static XPlaneCommand GPSGcu478M { get { return new XPlaneCommand("sim/GPS/gcu478/M", "GCU: M"); } }
        public static XPlaneCommand GPSGcu478N { get { return new XPlaneCommand("sim/GPS/gcu478/N", "GCU: N"); } }
        public static XPlaneCommand GPSGcu478O { get { return new XPlaneCommand("sim/GPS/gcu478/O", "GCU: O"); } }
        public static XPlaneCommand GPSGcu478P { get { return new XPlaneCommand("sim/GPS/gcu478/P", "GCU: P"); } }
        public static XPlaneCommand GPSGcu478Q { get { return new XPlaneCommand("sim/GPS/gcu478/Q", "GCU: Q"); } }
        public static XPlaneCommand GPSGcu478R { get { return new XPlaneCommand("sim/GPS/gcu478/R", "GCU: R"); } }
        public static XPlaneCommand GPSGcu478S { get { return new XPlaneCommand("sim/GPS/gcu478/S", "GCU: S"); } }
        public static XPlaneCommand GPSGcu478T { get { return new XPlaneCommand("sim/GPS/gcu478/T", "GCU: T"); } }
        public static XPlaneCommand GPSGcu478U { get { return new XPlaneCommand("sim/GPS/gcu478/U", "GCU: U"); } }
        public static XPlaneCommand GPSGcu478V { get { return new XPlaneCommand("sim/GPS/gcu478/V", "GCU: V"); } }
        public static XPlaneCommand GPSGcu478W { get { return new XPlaneCommand("sim/GPS/gcu478/W", "GCU: W"); } }
        public static XPlaneCommand GPSGcu478X { get { return new XPlaneCommand("sim/GPS/gcu478/X", "GCU: X"); } }
        public static XPlaneCommand GPSGcu478Y { get { return new XPlaneCommand("sim/GPS/gcu478/Y", "GCU: Y"); } }
        public static XPlaneCommand GPSGcu478Z { get { return new XPlaneCommand("sim/GPS/gcu478/Z", "GCU: Z"); } }
        public static XPlaneCommand GPSGcu4780 { get { return new XPlaneCommand("sim/GPS/gcu478/0", "GCU: 0"); } }
        public static XPlaneCommand GPSGcu4781 { get { return new XPlaneCommand("sim/GPS/gcu478/1", "GCU: 1"); } }
        public static XPlaneCommand GPSGcu4782 { get { return new XPlaneCommand("sim/GPS/gcu478/2", "GCU: 2"); } }
        public static XPlaneCommand GPSGcu4783 { get { return new XPlaneCommand("sim/GPS/gcu478/3", "GCU: 3"); } }
        public static XPlaneCommand GPSGcu4784 { get { return new XPlaneCommand("sim/GPS/gcu478/4", "GCU: 4"); } }
        public static XPlaneCommand GPSGcu4785 { get { return new XPlaneCommand("sim/GPS/gcu478/5", "GCU: 5"); } }
        public static XPlaneCommand GPSGcu4786 { get { return new XPlaneCommand("sim/GPS/gcu478/6", "GCU: 6"); } }
        public static XPlaneCommand GPSGcu4787 { get { return new XPlaneCommand("sim/GPS/gcu478/7", "GCU: 7"); } }
        public static XPlaneCommand GPSGcu4788 { get { return new XPlaneCommand("sim/GPS/gcu478/8", "GCU: 8"); } }
        public static XPlaneCommand GPSGcu4789 { get { return new XPlaneCommand("sim/GPS/gcu478/9", "GCU: 9"); } }
        public static XPlaneCommand GPSGcu478Dot { get { return new XPlaneCommand("sim/GPS/gcu478/dot", "GCU: dot"); } }
        public static XPlaneCommand GPSGcu478Minus { get { return new XPlaneCommand("sim/GPS/gcu478/minus", "GCU: minus"); } }
        public static XPlaneCommand GPSGcu478Spc { get { return new XPlaneCommand("sim/GPS/gcu478/spc", "GCU: space"); } }
        public static XPlaneCommand GPSGcu478Bksp { get { return new XPlaneCommand("sim/GPS/gcu478/bksp", "GCU: backspace"); } }
        public static XPlaneCommand GPSGcu478HdgUp { get { return new XPlaneCommand("sim/GPS/gcu478/hdg_up", "GCU: HDG up."); } }
        public static XPlaneCommand GPSGcu478HdgDown { get { return new XPlaneCommand("sim/GPS/gcu478/hdg_down", "GCU: HDG down."); } }
        public static XPlaneCommand GPSGcu478HdgSync { get { return new XPlaneCommand("sim/GPS/gcu478/hdg_sync", "GCU: HDG sync."); } }
        public static XPlaneCommand GPSGcu478CrsUp { get { return new XPlaneCommand("sim/GPS/gcu478/crs_up", "GCU: CRS up."); } }
        public static XPlaneCommand GPSGcu478CrsDown { get { return new XPlaneCommand("sim/GPS/gcu478/crs_down", "GCU: CRS down."); } }
        public static XPlaneCommand GPSGcu478CrsSync { get { return new XPlaneCommand("sim/GPS/gcu478/crs_sync", "GCU: CRS sync."); } }
        public static XPlaneCommand GPSGcu478AltUp { get { return new XPlaneCommand("sim/GPS/gcu478/alt_up", "GCU: altitude up."); } }
        public static XPlaneCommand GPSGcu478AltDown { get { return new XPlaneCommand("sim/GPS/gcu478/alt_down", "GCU: altitude down."); } }
        public static XPlaneCommand GPSGcu478AltSync { get { return new XPlaneCommand("sim/GPS/gcu478/alt_sync", "GCU: altitude sync."); } }
        public static XPlaneCommand GPSGcu478RangeUp { get { return new XPlaneCommand("sim/GPS/gcu478/range_up", "GCU: range up."); } }
        public static XPlaneCommand GPSGcu478RangeDown { get { return new XPlaneCommand("sim/GPS/gcu478/range_down", "GCU: range down."); } }
        public static XPlaneCommand GPSGcu478PanUp { get { return new XPlaneCommand("sim/GPS/gcu478/pan_up", "GCU: pan up."); } }
        public static XPlaneCommand GPSGcu478PanDown { get { return new XPlaneCommand("sim/GPS/gcu478/pan_down", "GCU: pan down."); } }
        public static XPlaneCommand GPSGcu478PanLeft { get { return new XPlaneCommand("sim/GPS/gcu478/pan_left", "GCU: pan left."); } }
        public static XPlaneCommand GPSGcu478PanRight { get { return new XPlaneCommand("sim/GPS/gcu478/pan_right", "GCU: pan right."); } }
        public static XPlaneCommand GPSGcu478PanUpLeft { get { return new XPlaneCommand("sim/GPS/gcu478/pan_up_left", "GCU: pan up left."); } }
        public static XPlaneCommand GPSGcu478PanDownLeft { get { return new XPlaneCommand("sim/GPS/gcu478/pan_down_left", "GCU: pan down left."); } }
        public static XPlaneCommand GPSGcu478PanUpRight { get { return new XPlaneCommand("sim/GPS/gcu478/pan_up_right", "GCU: pan up right."); } }
        public static XPlaneCommand GPSGcu478PanDownRight { get { return new XPlaneCommand("sim/GPS/gcu478/pan_down_right", "GCU: pan down right."); } }
        public static XPlaneCommand GPSGcu478PanPush { get { return new XPlaneCommand("sim/GPS/gcu478/pan_push", "GCU: push pan."); } }
        public static XPlaneCommand GPSGcu478Fms { get { return new XPlaneCommand("sim/GPS/gcu478/fms", "GCU: FMS"); } }
        public static XPlaneCommand GPSGcu478Xpdr { get { return new XPlaneCommand("sim/GPS/gcu478/xpdr", "GCU: XPDR"); } }
        public static XPlaneCommand GPSGcu478Com { get { return new XPlaneCommand("sim/GPS/gcu478/com", "GCU: COM"); } }
        public static XPlaneCommand GPSGcu478Nav { get { return new XPlaneCommand("sim/GPS/gcu478/nav", "GCU: NAV"); } }
        public static XPlaneCommand GPSGcu478Ff { get { return new XPlaneCommand("sim/GPS/gcu478/ff", "GCU: COM/NAV flip flop."); } }
        public static XPlaneCommand GPSGcu478Direct { get { return new XPlaneCommand("sim/GPS/gcu478/direct", "GCU: -D->."); } }
        public static XPlaneCommand GPSGcu478Menu { get { return new XPlaneCommand("sim/GPS/gcu478/menu", "GCU: menu."); } }
        public static XPlaneCommand GPSGcu478Fpl { get { return new XPlaneCommand("sim/GPS/gcu478/fpl", "GCU: FPL."); } }
        public static XPlaneCommand GPSGcu478Proc { get { return new XPlaneCommand("sim/GPS/gcu478/proc", "GCU: proc."); } }
        public static XPlaneCommand GPSGcu478Clr { get { return new XPlaneCommand("sim/GPS/gcu478/clr", "GCU: CLR."); } }
        public static XPlaneCommand GPSGcu478Ent { get { return new XPlaneCommand("sim/GPS/gcu478/ent", "GCU: ENT."); } }
        public static XPlaneCommand GPSGcu478OuterUp { get { return new XPlaneCommand("sim/GPS/gcu478/outer_up", "GCU: outer ring tune up."); } }
        public static XPlaneCommand GPSGcu478OuterDown { get { return new XPlaneCommand("sim/GPS/gcu478/outer_down", "GCU: outer ring tune down."); } }
        public static XPlaneCommand GPSGcu478InnerUp { get { return new XPlaneCommand("sim/GPS/gcu478/inner_up", "GCU: inner ring tune up."); } }
        public static XPlaneCommand GPSGcu478InnerDown { get { return new XPlaneCommand("sim/GPS/gcu478/inner_down", "GCU: inner ring tune down."); } }
        public static XPlaneCommand GPSGcu478Cursor { get { return new XPlaneCommand("sim/GPS/gcu478/cursor", "GCU: cursor/1-2."); } }
        public static XPlaneCommand GPSG1000DisplayReversion { get { return new XPlaneCommand("sim/GPS/G1000_display_reversion", "G1000 red button for display reversion (backup display)."); } }
        public static XPlaneCommand SystemsOverspeedTest { get { return new XPlaneCommand("sim/systems/overspeed_test", "Prop overspeed test."); } }
        public static XPlaneCommand FuelIndicateAux { get { return new XPlaneCommand("sim/fuel/indicate_aux", "Fuel tanks show auxiliary tanks."); } }
        public static XPlaneCommand FuelIndicateAll { get { return new XPlaneCommand("sim/fuel/indicate_all", "Fuel tanks show all tanks."); } }
        public static XPlaneCommand FuelIndicateNacelle { get { return new XPlaneCommand("sim/fuel/indicate_nacelle", "Fuel tanks show nacelle tanks."); } }
        public static XPlaneCommand AutopilotTestAutoAnnunciators { get { return new XPlaneCommand("sim/autopilot/test_auto_annunciators", "Autopilot test annunciators."); } }
        public static XPlaneCommand FlightControlsPitchTrimaUp { get { return new XPlaneCommand("sim/flight_controls/pitch_trimA_up", "Pitch trim A up."); } }
        public static XPlaneCommand FlightControlsPitchTrimaDown { get { return new XPlaneCommand("sim/flight_controls/pitch_trimA_down", "Pitch trim A down."); } }
        public static XPlaneCommand FlightControlsPitchTrimbUp { get { return new XPlaneCommand("sim/flight_controls/pitch_trimB_up", "Pitch trim B up."); } }
        public static XPlaneCommand FlightControlsPitchTrimbDown { get { return new XPlaneCommand("sim/flight_controls/pitch_trimB_down", "Pitch trim B down."); } }
        public static XPlaneCommand FlightControlsPitchTrimUp { get { return new XPlaneCommand("sim/flight_controls/pitch_trim_up", "Pitch trim up."); } }
        public static XPlaneCommand FlightControlsPitchTrimDown { get { return new XPlaneCommand("sim/flight_controls/pitch_trim_down", "Pitch trim down."); } }
        public static XPlaneCommand FlightControlsPitchTrimUpMech { get { return new XPlaneCommand("sim/flight_controls/pitch_trim_up_mech", "Pitch trim up - Mechanical, not servo."); } }
        public static XPlaneCommand FlightControlsPitchTrimDownMech { get { return new XPlaneCommand("sim/flight_controls/pitch_trim_down_mech", "Pitch trim down - Mechanical, not servo."); } }
        public static XPlaneCommand FlightControlsAileronTrimLeft { get { return new XPlaneCommand("sim/flight_controls/aileron_trim_left", "Roll trim left."); } }
        public static XPlaneCommand FlightControlsAileronTrimRight { get { return new XPlaneCommand("sim/flight_controls/aileron_trim_right", "Roll trim right."); } }
        public static XPlaneCommand FlightControlsRudderTrimLeft { get { return new XPlaneCommand("sim/flight_controls/rudder_trim_left", "Yaw trim left."); } }
        public static XPlaneCommand FlightControlsRudderTrimRight { get { return new XPlaneCommand("sim/flight_controls/rudder_trim_right", "Yaw trim right."); } }
        public static XPlaneCommand FlightControlsGyroRotorTrimUp { get { return new XPlaneCommand("sim/flight_controls/gyro_rotor_trim_up", "Gyro rotor trim up."); } }
        public static XPlaneCommand FlightControlsGyroRotorTrimDown { get { return new XPlaneCommand("sim/flight_controls/gyro_rotor_trim_down", "Gyro rotor trim down."); } }
        public static XPlaneCommand FlightControlsRotorRpmTrimUp { get { return new XPlaneCommand("sim/flight_controls/rotor_rpm_trim_up", "Rotor RPM trim up."); } }
        public static XPlaneCommand FlightControlsRotorRpmTrimDown { get { return new XPlaneCommand("sim/flight_controls/rotor_rpm_trim_down", "Rotor RPM trim down."); } }
        public static XPlaneCommand FlightControlsMagneticLock { get { return new XPlaneCommand("sim/flight_controls/magnetic_lock", "Controls magnetic lock."); } }
        public static XPlaneCommand FlightControlsPitchTrimTakeoff { get { return new XPlaneCommand("sim/flight_controls/pitch_trim_takeoff", "Pitch trim takeoff."); } }
        public static XPlaneCommand FlightControlsAileronTrimCenter { get { return new XPlaneCommand("sim/flight_controls/aileron_trim_center", "Aileron trim center."); } }
        public static XPlaneCommand FlightControlsRudderTrimCenter { get { return new XPlaneCommand("sim/flight_controls/rudder_trim_center", "Rudder trim center."); } }
        public static XPlaneCommand FlightControlsRudderLft { get { return new XPlaneCommand("sim/flight_controls/rudder_lft", "Rudder left."); } }
        public static XPlaneCommand FlightControlsRudderCtr { get { return new XPlaneCommand("sim/flight_controls/rudder_ctr", "Rudder center."); } }
        public static XPlaneCommand FlightControlsRudderRgt { get { return new XPlaneCommand("sim/flight_controls/rudder_rgt", "Rudder right."); } }
        public static XPlaneCommand AutopilotSetOttSeldispALTVVIVvi { get { return new XPlaneCommand("sim/autopilot/set_ott_seldisp_ALT_VVI_vvi", "Let ott_seldisp_ALT_VVI show VVI."); } }
        public static XPlaneCommand AutopilotSetOttSeldispALTVVIAlt { get { return new XPlaneCommand("sim/autopilot/set_ott_seldisp_ALT_VVI_alt", "Let ott_seldisp_ALT_VVI show ALT."); } }
        public static XPlaneCommand OperationGroundSpeedChange { get { return new XPlaneCommand("sim/operation/ground_speed_change", "Sim 1x 2x 4x ground speed."); } }
        public static XPlaneCommand OperationFreezeToggle { get { return new XPlaneCommand("sim/operation/freeze_toggle", "Freeze the groundspeed of the simulation."); } }
        public static XPlaneCommand InstrumentsTimerStartStop { get { return new XPlaneCommand("sim/instruments/timer_start_stop", "Start or stop the timer."); } }
        public static XPlaneCommand InstrumentsTimerReset { get { return new XPlaneCommand("sim/instruments/timer_reset", "Reset the timer."); } }
        public static XPlaneCommand InstrumentsTimerShowDate { get { return new XPlaneCommand("sim/instruments/timer_show_date", "Show date on the chrono."); } }
        public static XPlaneCommand InstrumentsTimerMode { get { return new XPlaneCommand("sim/instruments/timer_mode", "Timer/clock mode for chronos."); } }
        public static XPlaneCommand InstrumentsTimerCycle { get { return new XPlaneCommand("sim/instruments/timer_cycle", "Timer start/stop/reset."); } }
        public static XPlaneCommand OperationTimeDown { get { return new XPlaneCommand("sim/operation/time_down", "Time: a little earlier."); } }
        public static XPlaneCommand OperationTimeUp { get { return new XPlaneCommand("sim/operation/time_up", "Time: a little later."); } }
        public static XPlaneCommand OperationTimeDownLots { get { return new XPlaneCommand("sim/operation/time_down_lots", "Time: a lot earlier."); } }
        public static XPlaneCommand OperationTimeUpLots { get { return new XPlaneCommand("sim/operation/time_up_lots", "Time: a lot later."); } }
        public static XPlaneCommand OperationDateDown { get { return new XPlaneCommand("sim/operation/date_down", "Date: a little earlier."); } }
        public static XPlaneCommand OperationDateUp { get { return new XPlaneCommand("sim/operation/date_up", "Date: a little later."); } }
        public static XPlaneCommand InstrumentsTimerIsGMT { get { return new XPlaneCommand("sim/instruments/timer_is_GMT", "Timer is GMT."); } }
        public static XPlaneCommand OperationFlightmodelSpeedChange { get { return new XPlaneCommand("sim/operation/flightmodel_speed_change", "Sim 1x 2x 4x sim speed."); } }
        public static XPlaneCommand OperationPauseToggle { get { return new XPlaneCommand("sim/operation/pause_toggle", "Pause the simulation."); } }
        public static XPlaneCommand OperationVideoRecordToggle { get { return new XPlaneCommand("sim/operation/video_record_toggle", "Toggle AVI movie recording."); } }
        public static XPlaneCommand OperationConfigureVideoRecording { get { return new XPlaneCommand("sim/operation/configure_video_recording", "Configure AVI movie recording."); } }
        public static XPlaneCommand ReplayReplayToggle { get { return new XPlaneCommand("sim/replay/replay_toggle", "Toggle replay mode on/off."); } }
        public static XPlaneCommand ReplayReplayOff { get { return new XPlaneCommand("sim/replay/replay_off", "Replay mode off."); } }
        public static XPlaneCommand ReplayReplayControlsToggle { get { return new XPlaneCommand("sim/replay/replay_controls_toggle", "Replay mode: Toggle controls visibility."); } }
        public static XPlaneCommand ReplayRepBegin { get { return new XPlaneCommand("sim/replay/rep_begin", "Replay mode: go to beginning."); } }
        public static XPlaneCommand ReplayRepPlayFr { get { return new XPlaneCommand("sim/replay/rep_play_fr", "Replay mode: play fast reverse."); } }
        public static XPlaneCommand ReplayRepPlayRr { get { return new XPlaneCommand("sim/replay/rep_play_rr", "Replay mode: play reverse."); } }
        public static XPlaneCommand ReplayRepPlaySr { get { return new XPlaneCommand("sim/replay/rep_play_sr", "Replay mode: play slow reverse."); } }
        public static XPlaneCommand ReplayRepPause { get { return new XPlaneCommand("sim/replay/rep_pause", "Replay mode: pause."); } }
        public static XPlaneCommand ReplayRepPlaySf { get { return new XPlaneCommand("sim/replay/rep_play_sf", "Replay mode: play slow forward."); } }
        public static XPlaneCommand ReplayRepPlayRf { get { return new XPlaneCommand("sim/replay/rep_play_rf", "Replay mode: play forward."); } }
        public static XPlaneCommand ReplayRepPlayFf { get { return new XPlaneCommand("sim/replay/rep_play_ff", "Replay mode: play fast forward."); } }
        public static XPlaneCommand ReplayRepEnd { get { return new XPlaneCommand("sim/replay/rep_end", "Replay mode: go to end."); } }
        public static XPlaneCommand OperationToggleLogbook { get { return new XPlaneCommand("sim/operation/toggle_logbook", "Toggle logbook window."); } }
        public static XPlaneCommand OperationSaveFlight { get { return new XPlaneCommand("sim/operation/save_flight", "Toggle Save Flight window."); } }
        public static XPlaneCommand OperationLoadFlight { get { return new XPlaneCommand("sim/operation/load_flight", "Toggle Load Flight window."); } }
        public static XPlaneCommand OperationTextFileToggle { get { return new XPlaneCommand("sim/operation/text_file_toggle", "Toggle text file."); } }
        public static XPlaneCommand OperationChecklistToggle { get { return new XPlaneCommand("sim/operation/checklist_toggle", "Toggle checklist."); } }
        public static XPlaneCommand OperationChecklistNext { get { return new XPlaneCommand("sim/operation/checklist_next", "Next item in checklist."); } }
        public static XPlaneCommand OperationChecklistPrevious { get { return new XPlaneCommand("sim/operation/checklist_previous", "Previous item in checklist."); } }
        public static XPlaneCommand OperationContactAtc { get { return new XPlaneCommand("sim/operation/contact_atc", "Contact ATC."); } }
        public static XPlaneCommand OperationToggleAiFlies { get { return new XPlaneCommand("sim/operation/toggle_ai_flies", "Toggle AI flying your aircraft."); } }
        public static XPlaneCommand OperationToggleYoke { get { return new XPlaneCommand("sim/operation/toggle_yoke", "Toggle yoke visibility."); } }
        public static XPlaneCommand OperationResetFlight { get { return new XPlaneCommand("sim/operation/reset_flight", "Reset flight to most recent start."); } }
        public static XPlaneCommand OperationGoToDefault { get { return new XPlaneCommand("sim/operation/go_to_default", "Reset flight to nearest airport."); } }
        public static XPlaneCommand OperationResetToRunway { get { return new XPlaneCommand("sim/operation/reset_to_runway", "Reset flight to nearest runway."); } }
        public static XPlaneCommand OperationGoNextRunway { get { return new XPlaneCommand("sim/operation/go_next_runway", "Reset flight to next runway on current airport"); } }
        public static XPlaneCommand OperationGrassFieldTakeoff { get { return new XPlaneCommand("sim/operation/Grass_Field_Takeoff", "Grass field takeoff."); } }
        public static XPlaneCommand OperationDirtFieldTakeoff { get { return new XPlaneCommand("sim/operation/Dirt_Field_Takeoff", "Dirt field takeoff."); } }
        public static XPlaneCommand OperationGravelFieldTakeoff { get { return new XPlaneCommand("sim/operation/Gravel_Field_Takeoff", "Gravel field takeoff."); } }
        public static XPlaneCommand OperationWaterWayTakeoff { get { return new XPlaneCommand("sim/operation/Water_Way_Takeoff", "Waterway takeoff."); } }
        public static XPlaneCommand OperationHelipadTakeoff { get { return new XPlaneCommand("sim/operation/Helipad_Takeoff", "Helipad takeoff."); } }
        public static XPlaneCommand OperationCarrierCatshot { get { return new XPlaneCommand("sim/operation/Carrier_Catshot", "Carrier catshot."); } }
        public static XPlaneCommand OperationGliderWinch { get { return new XPlaneCommand("sim/operation/Glider_Winch", "Glider winch start."); } }
        public static XPlaneCommand OperationGliderTow { get { return new XPlaneCommand("sim/operation/Glider_Tow", "Glider tow start."); } }
        public static XPlaneCommand OperationAirDropFromB52 { get { return new XPlaneCommand("sim/operation/Air_Drop_from_B_52", "Airdrop from B-52."); } }
        public static XPlaneCommand OperationStartCarried { get { return new XPlaneCommand("sim/operation/start_carried", "Other aircraft carries your own."); } }
        public static XPlaneCommand OperationPiggybackShuttleOn747 { get { return new XPlaneCommand("sim/operation/Piggyback_Shuttle_on_747", "Piggyback Shuttle on 747."); } }
        public static XPlaneCommand OperationCarryOtherAircraft { get { return new XPlaneCommand("sim/operation/carry_other_aircraft", "Carry another aircraft."); } }
        public static XPlaneCommand OperationFormationFlying { get { return new XPlaneCommand("sim/operation/Formation_Flying", "Formation flying."); } }
        public static XPlaneCommand OperationAirRefuelBoom { get { return new XPlaneCommand("sim/operation/Air_Refuel_Boom", "Air refueling (boom)."); } }
        public static XPlaneCommand OperationAirRefuelBasket { get { return new XPlaneCommand("sim/operation/Air_Refuel_Basket", "Air refueling (basket)."); } }
        public static XPlaneCommand OperationAircraftCarrierApproach { get { return new XPlaneCommand("sim/operation/Aircraft_Carrier_Approach", "Aircraft carrier approach."); } }
        public static XPlaneCommand OperationFrigateApproach { get { return new XPlaneCommand("sim/operation/Frigate_Approach", "Frigate approach."); } }
        public static XPlaneCommand OperationMediumOilRigApproach { get { return new XPlaneCommand("sim/operation/Medium_Oil_Rig_Approach", "Medium oil rig approach."); } }
        public static XPlaneCommand OperationLargeOilPlatformApproach { get { return new XPlaneCommand("sim/operation/Large_Oil_Platform_Approach", "Large oil platform approach."); } }
        public static XPlaneCommand OperationForestFireApproach { get { return new XPlaneCommand("sim/operation/Forest_Fire_Approach", "Forest fire approach."); } }
        public static XPlaneCommand OperationSpaceShuttleFullReEntry { get { return new XPlaneCommand("sim/operation/Space_Shuttle_Full_Re_entry", "Space Shuttle: Full re-entry."); } }
        public static XPlaneCommand OperationSpaceShuttleFinalReEntry { get { return new XPlaneCommand("sim/operation/Space_Shuttle_Final_Re_entry", "Space Shuttle: Final re-entry."); } }
        public static XPlaneCommand OperationSpaceShuttleFullApproach { get { return new XPlaneCommand("sim/operation/Space_Shuttle_Full_Approach", "Space Shuttle: Full approach."); } }
        public static XPlaneCommand OperationSpaceShuttleFinalApproach { get { return new XPlaneCommand("sim/operation/Space_Shuttle_Final_Approach", "Space Shuttle: Final approach."); } }
        public static XPlaneCommand ViewAiControlsViews { get { return new XPlaneCommand("sim/view/ai_controls_views", "Toggle AI controls your views."); } }
        public static XPlaneCommand ViewFreeCamera { get { return new XPlaneCommand("sim/view/free_camera", "Free camera."); } }
        public static XPlaneCommand ViewDefaultView { get { return new XPlaneCommand("sim/view/default_view", "Default view."); } }
        public static XPlaneCommand ViewForwardWith2DPanel { get { return new XPlaneCommand("sim/view/forward_with_2d_panel", "Forward with 2-D panel."); } }
        public static XPlaneCommand ViewForwardWithHud { get { return new XPlaneCommand("sim/view/forward_with_hud", "Forward with HUD."); } }
        public static XPlaneCommand ViewForwardWithNothing { get { return new XPlaneCommand("sim/view/forward_with_nothing", "Forward with nothing."); } }
        public static XPlaneCommand ViewLinearSpot { get { return new XPlaneCommand("sim/view/linear_spot", "Linear spot."); } }
        public static XPlaneCommand ViewStillSpot { get { return new XPlaneCommand("sim/view/still_spot", "Still spot."); } }
        public static XPlaneCommand ViewRunway { get { return new XPlaneCommand("sim/view/runway", "Runway."); } }
        public static XPlaneCommand ViewCircle { get { return new XPlaneCommand("sim/view/circle", "Circle."); } }
        public static XPlaneCommand ViewTower { get { return new XPlaneCommand("sim/view/tower", "Tower."); } }
        public static XPlaneCommand ViewRidealong { get { return new XPlaneCommand("sim/view/ridealong", "Ride-along."); } }
        public static XPlaneCommand ViewTrackWeapon { get { return new XPlaneCommand("sim/view/track_weapon", "Track weapon."); } }
        public static XPlaneCommand ViewChase { get { return new XPlaneCommand("sim/view/chase", "Chase."); } }
        public static XPlaneCommand View3DCockpitCmndLook { get { return new XPlaneCommand("sim/view/3d_cockpit_cmnd_look", "3-D cockpit."); } }
        public static XPlaneCommand View3DCockpitToggle { get { return new XPlaneCommand("sim/view/3d_cockpit_toggle", "Toggle between 2-D and 3-D cockpit."); } }
        public static XPlaneCommand ViewLockGeo { get { return new XPlaneCommand("sim/view/lock_geo", "Lock onto current location."); } }
        public static XPlaneCommand ViewCinemaVerite { get { return new XPlaneCommand("sim/view/cinema_verite", "Cinema verite."); } }
        public static XPlaneCommand ViewSunglasses { get { return new XPlaneCommand("sim/view/sunglasses", "Sunglasses."); } }
        public static XPlaneCommand ViewNightVision { get { return new XPlaneCommand("sim/view/night_vision", "Night vision."); } }
        public static XPlaneCommand ViewFlashlightRed { get { return new XPlaneCommand("sim/view/flashlight_red", "Toggle the red flashlight."); } }
        public static XPlaneCommand ViewFlashlightWht { get { return new XPlaneCommand("sim/view/flashlight_wht", "Toggle the white flashlight."); } }
        public static XPlaneCommand ViewGlanceLeft { get { return new XPlaneCommand("sim/view/glance_left", "Glance left."); } }
        public static XPlaneCommand ViewGlanceRight { get { return new XPlaneCommand("sim/view/glance_right", "Glance right."); } }
        public static XPlaneCommand ViewUpLeft { get { return new XPlaneCommand("sim/view/up_left", "Glance up and left."); } }
        public static XPlaneCommand ViewUpRight { get { return new XPlaneCommand("sim/view/up_right", "Glance up and right."); } }
        public static XPlaneCommand ViewStraightUp { get { return new XPlaneCommand("sim/view/straight_up", "Glance straight up."); } }
        public static XPlaneCommand ViewStraightDown { get { return new XPlaneCommand("sim/view/straight_down", "Glance straight down."); } }
        public static XPlaneCommand ViewLeft45 { get { return new XPlaneCommand("sim/view/left_45", "Glance 45 degrees left."); } }
        public static XPlaneCommand ViewRight45 { get { return new XPlaneCommand("sim/view/right_45", "Glance 45 degrees right."); } }
        public static XPlaneCommand ViewLeft90 { get { return new XPlaneCommand("sim/view/left_90", "Glance 90 degrees left."); } }
        public static XPlaneCommand ViewRight90 { get { return new XPlaneCommand("sim/view/right_90", "Glance 90 degrees right."); } }
        public static XPlaneCommand ViewLeft135 { get { return new XPlaneCommand("sim/view/left_135", "Glance 135 degrees left."); } }
        public static XPlaneCommand ViewRight135 { get { return new XPlaneCommand("sim/view/right_135", "Glance 135 degrees right."); } }
        public static XPlaneCommand ViewBack { get { return new XPlaneCommand("sim/view/back", "Glance backward."); } }
        public static XPlaneCommand View3DPathToggle { get { return new XPlaneCommand("sim/view/3d_path_toggle", "3-D path toggle."); } }
        public static XPlaneCommand View3DPathReset { get { return new XPlaneCommand("sim/view/3d_path_reset", "3-D path reset."); } }
        public static XPlaneCommand ViewShowPhysicsModel { get { return new XPlaneCommand("sim/view/show_physics_model", "Toggle physics model visualization."); } }
        public static XPlaneCommand ViewMouseClickRegionsToggle { get { return new XPlaneCommand("sim/view/mouse_click_regions_toggle", "Toggle visualization of clickable cockpit areas."); } }
        public static XPlaneCommand ViewInstrumentDescriptionsToggle { get { return new XPlaneCommand("sim/view/instrument_descriptions_toggle", "Toggle instrument descriptions on hover."); } }
        public static XPlaneCommand ViewQuickLook0 { get { return new XPlaneCommand("sim/view/quick_look_0", "Go to save 3-D cockpit location #1."); } }
        public static XPlaneCommand ViewQuickLook1 { get { return new XPlaneCommand("sim/view/quick_look_1", "Go to save 3-D cockpit location #2."); } }
        public static XPlaneCommand ViewQuickLook2 { get { return new XPlaneCommand("sim/view/quick_look_2", "Go to save 3-D cockpit location #3."); } }
        public static XPlaneCommand ViewQuickLook3 { get { return new XPlaneCommand("sim/view/quick_look_3", "Go to save 3-D cockpit location #4."); } }
        public static XPlaneCommand ViewQuickLook4 { get { return new XPlaneCommand("sim/view/quick_look_4", "Go to save 3-D cockpit location #5."); } }
        public static XPlaneCommand ViewQuickLook5 { get { return new XPlaneCommand("sim/view/quick_look_5", "Go to save 3-D cockpit location #6."); } }
        public static XPlaneCommand ViewQuickLook6 { get { return new XPlaneCommand("sim/view/quick_look_6", "Go to save 3-D cockpit location #7."); } }
        public static XPlaneCommand ViewQuickLook7 { get { return new XPlaneCommand("sim/view/quick_look_7", "Go to save 3-D cockpit location #8."); } }
        public static XPlaneCommand ViewQuickLook8 { get { return new XPlaneCommand("sim/view/quick_look_8", "Go to save 3-D cockpit location #9."); } }
        public static XPlaneCommand ViewQuickLook9 { get { return new XPlaneCommand("sim/view/quick_look_9", "Go to save 3-D cockpit location #10."); } }
        public static XPlaneCommand ViewQuickLook10 { get { return new XPlaneCommand("sim/view/quick_look_10", "Go to save 3-D cockpit location #11."); } }
        public static XPlaneCommand ViewQuickLook11 { get { return new XPlaneCommand("sim/view/quick_look_11", "Go to save 3-D cockpit location #12."); } }
        public static XPlaneCommand ViewQuickLook12 { get { return new XPlaneCommand("sim/view/quick_look_12", "Go to save 3-D cockpit location #13."); } }
        public static XPlaneCommand ViewQuickLook13 { get { return new XPlaneCommand("sim/view/quick_look_13", "Go to save 3-D cockpit location #14."); } }
        public static XPlaneCommand ViewQuickLook14 { get { return new XPlaneCommand("sim/view/quick_look_14", "Go to save 3-D cockpit location #15."); } }
        public static XPlaneCommand ViewQuickLook15 { get { return new XPlaneCommand("sim/view/quick_look_15", "Go to save 3-D cockpit location #16."); } }
        public static XPlaneCommand ViewQuickLook16 { get { return new XPlaneCommand("sim/view/quick_look_16", "Go to save 3-D cockpit location #17."); } }
        public static XPlaneCommand ViewQuickLook17 { get { return new XPlaneCommand("sim/view/quick_look_17", "Go to save 3-D cockpit location #18."); } }
        public static XPlaneCommand ViewQuickLook18 { get { return new XPlaneCommand("sim/view/quick_look_18", "Go to save 3-D cockpit location #19."); } }
        public static XPlaneCommand ViewQuickLook19 { get { return new XPlaneCommand("sim/view/quick_look_19", "Go to save 3-D cockpit location #20."); } }
        public static XPlaneCommand ViewQuickLook0Mem { get { return new XPlaneCommand("sim/view/quick_look_0_mem", "Memorize 3-D cockpit location #1."); } }
        public static XPlaneCommand ViewQuickLook1Mem { get { return new XPlaneCommand("sim/view/quick_look_1_mem", "Memorize 3-D cockpit location #2."); } }
        public static XPlaneCommand ViewQuickLook2Mem { get { return new XPlaneCommand("sim/view/quick_look_2_mem", "Memorize 3-D cockpit location #3."); } }
        public static XPlaneCommand ViewQuickLook3Mem { get { return new XPlaneCommand("sim/view/quick_look_3_mem", "Memorize 3-D cockpit location #4."); } }
        public static XPlaneCommand ViewQuickLook4Mem { get { return new XPlaneCommand("sim/view/quick_look_4_mem", "Memorize 3-D cockpit location #5."); } }
        public static XPlaneCommand ViewQuickLook5Mem { get { return new XPlaneCommand("sim/view/quick_look_5_mem", "Memorize 3-D cockpit location #6."); } }
        public static XPlaneCommand ViewQuickLook6Mem { get { return new XPlaneCommand("sim/view/quick_look_6_mem", "Memorize 3-D cockpit location #7."); } }
        public static XPlaneCommand ViewQuickLook7Mem { get { return new XPlaneCommand("sim/view/quick_look_7_mem", "Memorize 3-D cockpit location #8."); } }
        public static XPlaneCommand ViewQuickLook8Mem { get { return new XPlaneCommand("sim/view/quick_look_8_mem", "Memorize 3-D cockpit location #9."); } }
        public static XPlaneCommand ViewQuickLook9Mem { get { return new XPlaneCommand("sim/view/quick_look_9_mem", "Memorize 3-D cockpit location #10."); } }
        public static XPlaneCommand ViewQuickLook10Mem { get { return new XPlaneCommand("sim/view/quick_look_10_mem", "Memorize 3-D cockpit location #11."); } }
        public static XPlaneCommand ViewQuickLook11Mem { get { return new XPlaneCommand("sim/view/quick_look_11_mem", "Memorize 3-D cockpit location #12."); } }
        public static XPlaneCommand ViewQuickLook12Mem { get { return new XPlaneCommand("sim/view/quick_look_12_mem", "Memorize 3-D cockpit location #13."); } }
        public static XPlaneCommand ViewQuickLook13Mem { get { return new XPlaneCommand("sim/view/quick_look_13_mem", "Memorize 3-D cockpit location #14."); } }
        public static XPlaneCommand ViewQuickLook14Mem { get { return new XPlaneCommand("sim/view/quick_look_14_mem", "Memorize 3-D cockpit location #15."); } }
        public static XPlaneCommand ViewQuickLook15Mem { get { return new XPlaneCommand("sim/view/quick_look_15_mem", "Memorize 3-D cockpit location #16."); } }
        public static XPlaneCommand ViewQuickLook16Mem { get { return new XPlaneCommand("sim/view/quick_look_16_mem", "Memorize 3-D cockpit location #17."); } }
        public static XPlaneCommand ViewQuickLook17Mem { get { return new XPlaneCommand("sim/view/quick_look_17_mem", "Memorize 3-D cockpit location #18."); } }
        public static XPlaneCommand ViewQuickLook18Mem { get { return new XPlaneCommand("sim/view/quick_look_18_mem", "Memorize 3-D cockpit location #19."); } }
        public static XPlaneCommand ViewQuickLook19Mem { get { return new XPlaneCommand("sim/view/quick_look_19_mem", "Memorize 3-D cockpit location #20."); } }
        public static XPlaneCommand GeneralLeft { get { return new XPlaneCommand("sim/general/left", "Move view left."); } }
        public static XPlaneCommand GeneralRight { get { return new XPlaneCommand("sim/general/right", "Move view right."); } }
        public static XPlaneCommand GeneralUp { get { return new XPlaneCommand("sim/general/up", "Move view up."); } }
        public static XPlaneCommand GeneralDown { get { return new XPlaneCommand("sim/general/down", "Move view down."); } }
        public static XPlaneCommand GeneralForward { get { return new XPlaneCommand("sim/general/forward", "Move view forward."); } }
        public static XPlaneCommand GeneralBackward { get { return new XPlaneCommand("sim/general/backward", "Move view backward."); } }
        public static XPlaneCommand GeneralZoomIn { get { return new XPlaneCommand("sim/general/zoom_in", "Zoom in."); } }
        public static XPlaneCommand GeneralZoomOut { get { return new XPlaneCommand("sim/general/zoom_out", "Zoom out."); } }
        public static XPlaneCommand GeneralHatSwitchLeft { get { return new XPlaneCommand("sim/general/hat_switch_left", "Hat switch left."); } }
        public static XPlaneCommand GeneralHatSwitchRight { get { return new XPlaneCommand("sim/general/hat_switch_right", "Hat switch right."); } }
        public static XPlaneCommand GeneralHatSwitchUp { get { return new XPlaneCommand("sim/general/hat_switch_up", "Hat switch up."); } }
        public static XPlaneCommand GeneralHatSwitchDown { get { return new XPlaneCommand("sim/general/hat_switch_down", "Hat switch down."); } }
        public static XPlaneCommand GeneralHatSwitchUpLeft { get { return new XPlaneCommand("sim/general/hat_switch_up_left", "Hat switch up + left."); } }
        public static XPlaneCommand GeneralHatSwitchUpRight { get { return new XPlaneCommand("sim/general/hat_switch_up_right", "Hat switch up + right."); } }
        public static XPlaneCommand GeneralHatSwitchDownLeft { get { return new XPlaneCommand("sim/general/hat_switch_down_left", "Hat switch down + left."); } }
        public static XPlaneCommand GeneralHatSwitchDownRight { get { return new XPlaneCommand("sim/general/hat_switch_down_right", "Hat switch down + right."); } }
        public static XPlaneCommand GeneralLeftFast { get { return new XPlaneCommand("sim/general/left_fast", "Move view left fast."); } }
        public static XPlaneCommand GeneralRightFast { get { return new XPlaneCommand("sim/general/right_fast", "Move view right fast."); } }
        public static XPlaneCommand GeneralUpFast { get { return new XPlaneCommand("sim/general/up_fast", "Move view up fast."); } }
        public static XPlaneCommand GeneralDownFast { get { return new XPlaneCommand("sim/general/down_fast", "Move view down fast."); } }
        public static XPlaneCommand GeneralForwardFast { get { return new XPlaneCommand("sim/general/forward_fast", "Move view forward fast."); } }
        public static XPlaneCommand GeneralBackwardFast { get { return new XPlaneCommand("sim/general/backward_fast", "Move view backward fast."); } }
        public static XPlaneCommand GeneralZoomInFast { get { return new XPlaneCommand("sim/general/zoom_in_fast", "Zoom in fast."); } }
        public static XPlaneCommand GeneralZoomOutFast { get { return new XPlaneCommand("sim/general/zoom_out_fast", "Zoom out fast."); } }
        public static XPlaneCommand GeneralLeftSlow { get { return new XPlaneCommand("sim/general/left_slow", "Move view left slow."); } }
        public static XPlaneCommand GeneralRightSlow { get { return new XPlaneCommand("sim/general/right_slow", "Move view right slow."); } }
        public static XPlaneCommand GeneralUpSlow { get { return new XPlaneCommand("sim/general/up_slow", "Move view up slow."); } }
        public static XPlaneCommand GeneralDownSlow { get { return new XPlaneCommand("sim/general/down_slow", "Move view down slow."); } }
        public static XPlaneCommand GeneralForwardSlow { get { return new XPlaneCommand("sim/general/forward_slow", "Move view forward slow."); } }
        public static XPlaneCommand GeneralBackwardSlow { get { return new XPlaneCommand("sim/general/backward_slow", "Move view backward slow."); } }
        public static XPlaneCommand GeneralZoomInSlow { get { return new XPlaneCommand("sim/general/zoom_in_slow", "Zoom in slow."); } }
        public static XPlaneCommand GeneralZoomOutSlow { get { return new XPlaneCommand("sim/general/zoom_out_slow", "Zoom out slow."); } }
        public static XPlaneCommand GeneralRotUp { get { return new XPlaneCommand("sim/general/rot_up", "Rotate view: tilt up."); } }
        public static XPlaneCommand GeneralRotDown { get { return new XPlaneCommand("sim/general/rot_down", "Rotate view: tilt down."); } }
        public static XPlaneCommand GeneralRotLeft { get { return new XPlaneCommand("sim/general/rot_left", "Rotate view: pan left."); } }
        public static XPlaneCommand GeneralRotRight { get { return new XPlaneCommand("sim/general/rot_right", "Rotate view: pan right."); } }
        public static XPlaneCommand GeneralRotUpFast { get { return new XPlaneCommand("sim/general/rot_up_fast", "Rotate view: tilt up fast."); } }
        public static XPlaneCommand GeneralRotDownFast { get { return new XPlaneCommand("sim/general/rot_down_fast", "Rotate view: tilt down fast."); } }
        public static XPlaneCommand GeneralRotLeftFast { get { return new XPlaneCommand("sim/general/rot_left_fast", "Rotate view: pan left fast."); } }
        public static XPlaneCommand GeneralRotRightFast { get { return new XPlaneCommand("sim/general/rot_right_fast", "Rotate view: pan right fast."); } }
        public static XPlaneCommand GeneralRotUpSlow { get { return new XPlaneCommand("sim/general/rot_up_slow", "Rotate view: tilt up slow."); } }
        public static XPlaneCommand GeneralRotDownSlow { get { return new XPlaneCommand("sim/general/rot_down_slow", "Rotate view: tilt down slow."); } }
        public static XPlaneCommand GeneralRotLeftSlow { get { return new XPlaneCommand("sim/general/rot_left_slow", "Rotate view: pan left slow."); } }
        public static XPlaneCommand GeneralRotRightSlow { get { return new XPlaneCommand("sim/general/rot_right_slow", "Rotate view: pan right slow."); } }
        public static XPlaneCommand GeneralTrackP0 { get { return new XPlaneCommand("sim/general/track_p0", "Views track aircraft: Yours."); } }
        public static XPlaneCommand GeneralTrackPNext { get { return new XPlaneCommand("sim/general/track_p_next", "Views track aircraft: Next"); } }
        public static XPlaneCommand GeneralTrackPPrev { get { return new XPlaneCommand("sim/general/track_p_prev", "Views track aircraft: Previous."); } }
        public static XPlaneCommand GeneralToggleArtificialStabWin { get { return new XPlaneCommand("sim/general/toggle_artificial_stab_win", "Toggle the artificial stability constants window."); } }
        public static XPlaneCommand GeneralToggleTrafficPaths { get { return new XPlaneCommand("sim/general/toggle_traffic_paths", "Toggle display of traffic paths."); } }
        public static XPlaneCommand GeneralToggleAutopilotConstantsWin { get { return new XPlaneCommand("sim/general/toggle_autopilot_constants_win", "Toggle the autopilot constants window."); } }
        public static XPlaneCommand GeneralToggleFadecWin { get { return new XPlaneCommand("sim/general/toggle_fadec_win", "Toggle the FADEC constants window."); } }
        public static XPlaneCommand GeneralToggleControlDeflectionsWin { get { return new XPlaneCommand("sim/general/toggle_control_deflections_win", "Toggle the control deflections window."); } }
        public static XPlaneCommand GeneralToggleWeaponGuidanceWin { get { return new XPlaneCommand("sim/general/toggle_weapon_guidance_win", "Toggle the weapon guidance window."); } }
        public static XPlaneCommand DeveloperToggleTextureBrowser { get { return new XPlaneCommand("sim/developer/toggle_texture_browser", "Toggle the texture browser window."); } }
        public static XPlaneCommand DeveloperToggleParticleBrowser { get { return new XPlaneCommand("sim/developer/toggle_particle_browser", "Toggle the particle system browser window."); } }
        public static XPlaneCommand GeneralToggleProjectionWin { get { return new XPlaneCommand("sim/general/toggle_projection_win", "Toggle the projection configuration window."); } }
        public static XPlaneCommand DeveloperToggleMicroprofiler { get { return new XPlaneCommand("sim/developer/toggle_microprofiler", "Toggle the frame timing profiler window."); } }
        public static XPlaneCommand DeveloperToggleVramProfiler { get { return new XPlaneCommand("sim/developer/toggle_vram_profiler", "Toggle the VRAM profiler window."); } }
        public static XPlaneCommand DeveloperTogglePluginAdmin { get { return new XPlaneCommand("sim/developer/toggle_plugin_admin", "Toggle the Plugin Admin window."); } }
        public static XPlaneCommand OperationToggleSkyColorsWin { get { return new XPlaneCommand("sim/operation/toggle_sky_colors_win", "Toggle the sky colors window."); } }
        public static XPlaneCommand VRXpadHomeButton { get { return new XPlaneCommand("sim/VR/xpad/home_button", "Press the Home Button of the VR xPad."); } }
        public static XPlaneCommand VRToggle3DMouseCursor { get { return new XPlaneCommand("sim/VR/toggle_3d_mouse_cursor", "Toggle the 3-d mouse cursor in VR."); } }
        public static XPlaneCommand VRToggleVr { get { return new XPlaneCommand("sim/VR/toggle_vr", "Toggle enabling of VR hardware."); } }
        public static XPlaneCommand VRGeneralResetView { get { return new XPlaneCommand("sim/VR/general/reset_view", "Reset VR View."); } }
        public static XPlaneCommand VRQuickZoomView { get { return new XPlaneCommand("sim/VR/quick_zoom_view", "Temporarily and Quickly Zoom in while in VR."); } }
        public static XPlaneCommand VRReservedSelect { get { return new XPlaneCommand("sim/VR/reserved/select", "Reserved: VR Select/Trigger Button."); } }
        public static XPlaneCommand VRReservedMenu { get { return new XPlaneCommand("sim/VR/reserved/menu", "Reserved: VR Menu Button."); } }
        public static XPlaneCommand VRReservedTouchpad { get { return new XPlaneCommand("sim/VR/reserved/touchpad", "Reserved: VR Thumbstick/Touchpad Button."); } }
    }
}
