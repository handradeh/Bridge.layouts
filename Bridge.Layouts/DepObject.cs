namespace Bridge.Layouts
{
    [Ignore]
    [Namespace("layouts")]
    public interface ISupportCollectionChanged
    {
       object onCollectionChanged(object collection, object[] added, object[] removed, int startRemoveIndex);
        
    }
    [External]
    [Namespace("layouts")]
    public interface ISupportCommandCanExecuteChanged
    {
       object   onCommandCanExecuteChanged(Command command);//: any;
    }
    [External]
    [Namespace("layouts")]
    public class DepObject
{
        //private static globalPropertyMap;
        //    static registerProperty(typeName: string, name: string, defaultValue?: any, options?: any, converter?: {
        //    (value: string): any;
        //}): DepProperty;
        //    static getProperty(typeName: string, name: string): DepProperty;
        //    static getProperties(typeName: string): DepProperty[];
        //    static forAllProperties(obj: DepObject, callback: (depProperty: DepProperty) => void): void;
        //    static lookupProperty(obj: DepObject, name: string): DepProperty;
        //    protected localPropertyValueMap: {
        //        [propertyName: string]: any;
        //    };
        //    getValue(property: DepProperty): any;
        //    setValue(property: DepProperty, value: any): void;
        //    resetValue(property: DepProperty): void;
        //    protected onDependencyPropertyChanged(property: DepProperty, value: any, oldValue: any): void;
        //    private dpcHandlers;
        //    subscribeDependencyPropertyChanges(observer: ISupportDependencyPropertyChange): void;
        //    unsubscribeDependencyPropertyChanges(observer: ISupportDependencyPropertyChange): void;
        public void onPropertyChanged(string propertyName,object  value,object  oldValue) {
        }//: void;
    //    private pcHandlers;
    //    subscribePropertyChanges(observer: ISupportPropertyChange): void;
    //    unsubscribePropertyChanges(observer: ISupportPropertyChange): void;
    //    private bindings;
    //    bind(property: DepProperty, propertyPath: string, twoway: boolean, source: DepObject, converter?: IConverter, converterParameter?: any, format?: string): void;
    //    static logBindingTraceToConsole: boolean;
 }
}