"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Basket = void 0;
var uuid_1 = require("uuid");
var Basket = /** @class */ (function () {
    function Basket() {
        this.id = uuid_1.v4();
        this.items = [];
    }
    return Basket;
}());
exports.Basket = Basket;
//# sourceMappingURL=basket.js.map