public class Manager : Singleton<Manager>
{
    /** 资源管理 */
    private static AssetsManager _assetsManager = AssetsManager.GetInstance();
    public static AssetsManager assets
    {
        get { return _assetsManager; }
    }

    /** ui管理 */
    private static UIManager _uiManager = UIManager.GetInstance();
    public static UIManager ui
    {
        get { return _uiManager; }
    }

    /** 路径管理 */
    private static PathManager _pathManager = PathManager.GetInstance();
    public static PathManager path
    {
        get { return _pathManager; }
    }
}
