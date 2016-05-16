using Bridge.Layouts;

namespace Bridge.Layouts
{
   public  class UIElement : DepObject,ISupportCommandCanExecuteChanged
   {
    //    static string typeName;
    //    //typeName: string;
    //    desiredSize: Size;
    //    renderSize: Size;
    //    private previousAvailableSize;
    //    measure(availableSize: Size): void;
    //    protected measureCore(availableSize: Size): Size;
    //    private finalRect;
    //    private previousFinalRect;
    //    arrange(finalRect: Rect): void;
    //    protected arrangeCore(finalRect: Rect): void;
    //    protected relativeOffset: Vector;
    //    layout(relativeOffset?: Vector): void;
    //    protected layoutOverride(): void;
    //    protected _visual: HTMLElement;
    //    attachVisual(elementContainer: HTMLElement, showImmediately?: boolean): void;
    //    protected attachVisualOverride(elementContainer: HTMLElement): void;
    //    protected onMouseDown(ev: MouseEvent): void;
    //    protected onMouseUp(ev: MouseEvent): void;
    //    getBoundingClientRect(): ClientRect;
    //    protected visualConnected(elementContainer: HTMLElement): void;
    //    protected parentVisualConnected(parent: UIElement, elementContainer: HTMLElement): void;
    //    protected visualDisconnected(elementContainer: HTMLElement): void;
    //    protected parentVisualDisconnected(parent: UIElement, elementContainer: HTMLElement): void;
    //    protected onDependencyPropertyChanged(property: DepProperty, value: any, oldValue: any): void;
          public object  onCommandCanExecuteChanged(Command command){
            return default(object);
          }//: void;
    //    getValue(property: DepProperty): any;
    //    private measureDirty;
    //    invalidateMeasure(): void;
    //    private arrangeDirty;
    //    invalidateArrange(): void;
    //    private layoutInvalid;
    //    invalidateLayout(): void;
    //    private _logicalChildren;
    //    findElementByName(name: string): UIElement;
    //    private _parent;
    //    parent: UIElement;
    //    private notifyInheritsPropertiesChange();
    //    private onParentDependencyPropertyChanged(property);
    //    protected onParentChanged(oldParent: DepObject, newParent: DepObject): void;
    //    protected _extendedProperties: ExtendedProperty[];
    //    addExtentedProperty(name: string, value: string): void;
    //    static isVisibleProperty: DepProperty;
    //    isVisible: boolean;
    //    static classProperty: DepProperty;
    //    cssClass: string;
    //    static idProperty: DepProperty;
    //    id: string;
    //    static commandProperty: DepProperty;
    //    command: Command;
    //    static commandParameterProperty: DepProperty;
    //    commandParameter: any;
    //    static popupProperty: DepProperty;
    //    popup: any;
    //    static layoutUpdatedProperty: DepProperty;
    //    layoutUpdated: EventAction;
            }

}